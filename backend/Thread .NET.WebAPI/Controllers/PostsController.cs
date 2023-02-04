using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Thread_.NET.BLL.Services;
using Thread_.NET.Common.DTO.Like;
using Thread_.NET.Common.DTO.Post;
using Thread_.NET.Common.DTO.User;
using Thread_.NET.Extensions;

namespace Thread_.NET.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly PostService _postService;
        private readonly LikeService _likeService;
        private readonly DislikeService _dislikeService;

        public PostsController(PostService postService, LikeService likeService, DislikeService dislikeService)
        {
            _postService = postService;
            _likeService = likeService;
            _dislikeService = dislikeService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<ICollection<PostDTO>>> Get()
        {
            return Ok(await _postService.GetAllPosts());
        }

        [HttpPost]
        public async Task<ActionResult<PostDTO>> CreatePost([FromBody] PostCreateDTO dto)
        {
            dto.AuthorId = this.GetUserIdFromToken();

            return Ok(await _postService.CreatePost(dto));
        }

        [HttpPut]
        public async Task<ActionResult<PostDTO>> UpdatePost([FromBody] PostUpdateDto dto)
        {
            dto.AuthorId = this.GetUserIdFromToken();

            return Ok(await _postService.UpdatePost(dto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            await _postService.DeletePost(id);
            return NoContent();
        }

        [HttpPost("like")]
        public async Task<IActionResult> LikePost(NewReactionDTO reaction)
        {
            reaction.UserId = this.GetUserIdFromToken();

            await _likeService.LikePost(reaction);
            return Ok();
        }

        [HttpPost("dislike")]
        public async Task<IActionResult> DislikePost(NewReactionDTO reaction)
        {
            reaction.UserId = this.GetUserIdFromToken();

            await _dislikeService.DislikePost(reaction);
            return Ok();
        }
    }
}