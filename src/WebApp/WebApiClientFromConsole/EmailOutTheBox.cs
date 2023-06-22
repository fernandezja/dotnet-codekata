using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiClientFromConsole
{
    internal class EmailOutTheBox
    {
        [JsonPropertyName("mailId")]
        public int Id { get; set; }

        [JsonPropertyName("asunto")]
        public string Subject { get; set; }

        [JsonPropertyName("contenido")]
        public string Content { get; set; }
    }
}
