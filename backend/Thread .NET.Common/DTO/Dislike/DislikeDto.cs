using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thread_.NET.Common.DTO.User;

namespace Thread_.NET.Common.DTO.Dislike
{
    public class DislikeDto
    {
        public bool IsDislike { get; set; }
        public UserDTO User { get; set; }
    }
}
