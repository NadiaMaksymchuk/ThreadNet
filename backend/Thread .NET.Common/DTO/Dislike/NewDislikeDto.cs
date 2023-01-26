using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_.NET.Common.DTO.Dislike
{
    public class NewDislikeDto
    {
        public int EntityId { get; set; }
        public bool IsDislike { get; set; }
        public int UserId { get; set; }
    }
}
