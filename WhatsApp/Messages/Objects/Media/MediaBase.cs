using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WhatsApp.Messages.Objects.Media
{
    public abstract class MediaBase
    {
        [JsonPropertyName("id")]
        public string? Id;

        [JsonPropertyName("link")]
        public string? Link;

        [JsonPropertyName("caption")]
        public string? Caption;

        [JsonPropertyName("filename")] 
        public string? FileName;

        protected MediaBase(string? id = null, string? link = null, string? caption = null, string? filename = null)
        {
            Id = id;
            Link = link;
            Caption = caption;
            FileName = filename;

        }
    }
}
