﻿using AutoMapper;
using System.Linq;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.DAL.Context;

namespace Thread_.NET.BLL.Services
{
    public sealed class LikeService : BaseService
    {
        public LikeService(ThreadContext context, IMapper mapper) : base(context, mapper) { }

        public async Task LikePost(NewReactionDTO reaction)
        {
            var likes = _context.PostReactions.Where(x => x.UserId == reaction.UserId && x.PostId == reaction.EntityId && x.IsLike == true);
            var dislikes = _context.PostReactions.Where(x => x.UserId == reaction.UserId && x.PostId == reaction.EntityId);

            if (likes.Any())
            {
                _context.PostReactions.RemoveRange(likes);
                await _context.SaveChangesAsync();

                return;
            }

            if (dislikes.Any())
            {
                _context.PostReactions.RemoveRange(dislikes);
            }

            _context.PostReactions.Add(new DAL.Entities.PostReaction
            {
                PostId = reaction.EntityId,
                IsLike = reaction.IsLike,
                IsDislike = reaction.IsDislike,
                UserId = reaction.UserId
            });

            await _context.SaveChangesAsync();
        }

        public async Task LikeComment(NewReactionDTO reaction)
        {
            var likes = _context.CommentReactions.Where(x => x.UserId == reaction.UserId && x.CommentId == reaction.EntityId && x.IsLike == true);
            var dislikes = _context.CommentReactions.Where(x => x.UserId == reaction.UserId && x.CommentId == reaction.EntityId);

            if (likes.Any())
            {
                _context.CommentReactions.RemoveRange(likes);
                await _context.SaveChangesAsync();

                return;
            }

            if (dislikes.Any())
            {
                _context.CommentReactions.RemoveRange(dislikes);
            }

            _context.CommentReactions.Add(new DAL.Entities.CommentReaction
            {
                CommentId = reaction.EntityId,
                IsLike = reaction.IsLike,
                IsDislike = reaction.IsDislike,
                UserId = reaction.UserId
            });

            await _context.SaveChangesAsync();
        }
    }
}
