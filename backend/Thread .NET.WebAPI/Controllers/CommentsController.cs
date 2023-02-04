using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services;
using Thread_.NET.Common.DTO.Comment;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.Common.DTO.Post;
using Thread_.NET.Extensions;

namespace Thread_.NET.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly CommentService _commentService;
        private readonly LikeService _likeService;
        private readonly DislikeService _dislikeService;

        public CommentsController(CommentService commentService, LikeService likeService, DislikeService dislikeService)
        {
            _commentService = commentService;
            _likeService = likeService;
            _dislikeService = dislikeService;
        }

        [HttpPost]
        public async Task<ActionResult<CommentDTO>> CreateComment([FromBody] NewCommentDTO comment)
        {
            comment.AuthorId = this.GetUserIdFromToken();
            return Ok(await _commentService.CreateComment(comment));
        }


        [HttpPut]
        public async Task<ActionResult<PostDTO>> UpdatePost([FromBody] UpdateCommentDto dto)
        {
            dto.AuthorId = this.GetUserIdFromToken();

            return Ok(await _commentService.UpdateComment(dto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            await _commentService.DeleteComment(id);
            return NoContent();
        }

        [HttpPost("like")]
        public async Task<IActionResult> LikePost(NewReactionDTO reaction)
        {
            reaction.UserId = this.GetUserIdFromToken();

            await _likeService.LikeComment(reaction);
            return Ok();
        }

        [HttpPost("dislike")]
        public async Task<IActionResult> DislikePost(NewReactionDTO reaction)
        {
            reaction.UserId = this.GetUserIdFromToken();

            await _dislikeService.DislikeComment(reaction);
            return Ok();
        }
    }
}