using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_.NET.Common.DTO.Comment
{
    public class UpdateCommentDto
    {
        public int CommentId { get; set; }
        public int AuthorId { get; set; }
        public int PostId { get; set; }
        public string Body { get; set; }
    }
}
