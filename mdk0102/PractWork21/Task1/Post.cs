using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task1
{
    public class Post
    {
        [JsonPropertyName("userId")]
        public int IdUser { get; set; }
        [JsonPropertyName("id")]
        public int IdPost { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("body")]
        public string Body { get; set; }
    }
}
