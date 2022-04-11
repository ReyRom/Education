using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task1
{
    public class User
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Login { get; set; }
        [JsonPropertyName("CommentsList")]
        public List<string> Comments { get; set; }

        [JsonInclude]
        public Person personInfo;
    }
}
