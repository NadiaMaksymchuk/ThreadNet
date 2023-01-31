using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.BLL.Exceptions;
using Thread_.NET.BLL.Hubs;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Post;
using Thread_.NET.Common.DTO.User;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.Services
{
    public sealed class PostService : BaseService
    {
        private readonly IHubContext<PostHub> _postHub;

        public PostService(ThreadContext context, IMapper mapper, IHubContext<PostHub> postHub) : base(context, mapper)
        {
            _postHub = postHub;
        }

        public async Task<ICollection<PostDTO>> GetAllPosts()
        {
            var posts = await _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .Include(post => post.Preview)
                .Include(post => post.Reactions)
                    .ThenInclude(reaction => reaction.User)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Reactions)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Author)
                .OrderByDescending(post => post.CreatedAt)
                .ToListAsync();

            return _mapper.Map<ICollection<PostDTO>>(posts);
        }

        public async Task<ICollection<PostDTO>> GetAllPosts(int userId)
        {
            var posts = await _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .Include(post => post.Preview)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Author)
                .Where(p => p.AuthorId == userId) // Filter here
                .ToListAsync();

            return _mapper.Map<ICollection<PostDTO>>(posts);
        }

        public async Task<PostDTO> CreatePost(PostCreateDTO postDto)
        {
            var postEntity = _mapper.Map<Post>(postDto);

            _context.Posts.Add(postEntity);
            await _context.SaveChangesAsync();

            var createdPost = await _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .FirstAsync(post => post.Id == postEntity.Id);

            var createdPostDTO = _mapper.Map<PostDTO>(createdPost);
            await _postHub.Clients.All.SendAsync("NewPost", createdPostDTO);

            return createdPostDTO;
        }

        public async Task DeletePost(int id)
        {
            var postReaction = await _context.PostReactions.FirstOrDefaultAsync(x => x.PostId == id);

            if(postReaction is not null)
            {
                _context.PostReactions.RemoveRange(postReaction);
            }    
            var post = await _context.Posts.FirstOrDefaultAsync(x => x.Id == id);
 
            _context.Posts.RemoveRange(post);
            await _context.SaveChangesAsync();
        }

        public async Task<PostDTO> UpdatePost(PostUpdateDto updateDto)
        {
            var postEntity = await GetPostByIdInternal(updateDto.PostId);

            if (postEntity is null)
            {
                throw new NotFoundException(nameof(Post), updateDto.PostId);
            }

            var newPostEntity = _mapper.Map<Post>(updateDto);
            var timeNow = DateTime.Now;

            postEntity.Body = newPostEntity.Body;
            postEntity.UpdatedAt = timeNow;
            postEntity.Preview = newPostEntity.Preview;

            _context.Posts.Update(postEntity);
            await _context.SaveChangesAsync();

            var updatePostDTO = _mapper.Map<PostDTO>(postEntity);

            return updatePostDTO;
        }

        public async Task<ICollection<UserDTO>> GetAllUsersThatLikePost(int postId)
        {
            var users = await _context.PostReactions
                .Where(r => r.IsLike == true && r.PostId == postId)
                .Select(u => u.User)
                .ToListAsync();

            return _mapper.Map<ICollection<UserDTO>>(users);
        }

        public async Task<ICollection<UserDTO>> GetAllUsersThatDislikePost(int postId)
        {
            var users = await _context.PostReactions
                .Where(r => r.IsDislike == true && r.PostId == postId)
                .Select(u => u.User)
                .ToListAsync();

            return _mapper.Map<ICollection<UserDTO>>(users);
        }


        private async Task<Post> GetPostByIdInternal(int id)
        {
            return await _context.Posts
                .Include(post => post.Author)
                    .ThenInclude(author => author.Avatar)
                .Include(post => post.Preview)
                .Include(post => post.Reactions)
                    .ThenInclude(reaction => reaction.User)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Reactions)
                .Include(post => post.Comments)
                    .ThenInclude(comment => comment.Author)
                .FirstOrDefaultAsync(post => post.Id == id);
        }
    }
}
