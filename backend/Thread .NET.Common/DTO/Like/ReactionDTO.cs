using Thread_.NET.Common.DTO.User;

namespace Thread_.NET.Common.DTO.Like
{
    public sealed class ReactionDTO
    {
        public bool IsLike { get; set; }
        public bool IsDislike { get; set; }
        public UserDTO User { get; set; }
    }
}
