using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Thread_.NET.BLL.Exceptions;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Comment;
using Thread_.NET.Common.DTO.Post;
using Thread_.NET.DAL.Context;
using Thread_.NET.DAL.Entities;

namespace Thread_.NET.BLL.Services
{
    public sealed class CommentService : BaseService
    {
        public CommentService(ThreadContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<CommentDTO> CreateComment(NewCommentDTO newComment)
        {
            var commentEntity = _mapper.Map<Comment>(newComment);

            _context.Comments.Add(commentEntity);
            await _context.SaveChangesAsync();

            var createdComment = await _context.Comments
                .Include(comment => comment.Author)
                    .ThenInclude(user => user.Avatar)
                .FirstAsync(comment => comment.Id == commentEntity.Id);

            return _mapper.Map<CommentDTO>(createdComment);
        }

        public async Task DeleteComment(int id)
        {
            var commentReaction = await _context.CommentReactions.FirstOrDefaultAsync(x => x.CommentId == id);

            if (commentReaction is not null)
            {
                _context.CommentReactions.RemoveRange(commentReaction);
            }
            var comment = await _context.Comments.FirstOrDefaultAsync(x => x.Id == id);

            _context.Comments.RemoveRange(comment);
            await _context.SaveChangesAsync();
        }

        public async Task<CommentDTO> UpdateComment(UpdateCommentDto updateDto)
        {
            var updatedComment = await _context.Comments
                .Include(comment => comment.Author)
                    .ThenInclude(user => user.Avatar)
                .FirstAsync(comment => comment.Id == updateDto.CommentId);

            if (updatedComment is null)
            {
                throw new NotFoundException(nameof(Comment), updateDto.PostId);
            }

            var newCommentEntity = _mapper.Map<Comment>(updateDto);
            var timeNow = DateTime.Now;

            updatedComment.Body = newCommentEntity.Body;
            updatedComment.UpdatedAt = timeNow;

            _context.Comments.Update(updatedComment);
            await _context.SaveChangesAsync();

            var updateCommentDTO = _mapper.Map<CommentDTO>(updatedComment);

            return updateCommentDTO;
        }
    }
}
