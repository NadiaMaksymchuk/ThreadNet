using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services.Abstract;
using Thread_.NET.Common.DTO.Dislike;
using Thread_.NET.DAL.Context;

namespace Thread_.NET.BLL.Services
{
    public class DislikeService : BaseService
    {
        public DislikeService(ThreadContext context, IMapper mapper) : base(context, mapper) { }

        public async Task DislikePost(NewDislikeDto reaction)
        {
            var dislikes = _context.PostReactions.Where(x => x.UserId == reaction.UserId && x.PostId == reaction.EntityId);

            if (dislikes.Any())
            {
                _context.PostReactions.RemoveRange(dislikes);
                await _context.SaveChangesAsync();

                return;
            }

            _context.PostReactions.Add(new DAL.Entities.PostReaction
            {
                PostId = reaction.EntityId,
                IsDislike = reactionIsDislike,
                UserId = reaction.UserId
            });

            await _context.SaveChangesAsync();
        }
    }
}
