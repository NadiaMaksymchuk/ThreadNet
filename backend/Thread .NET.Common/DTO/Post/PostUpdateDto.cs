using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Thread_.NET.Common.DTO.Post
{
    public class PostUpdateDto
    {
        [JsonIgnore]
        public int AuthorId { get; set; }

        public int PostId { get; set; }

        public string PreviewImage { get; set; }
        public string Body { get; set; }
    }
}
