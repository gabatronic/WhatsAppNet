using Newtonsoft.Json;

namespace WhatsApp.Messages.Objects.Media
{
    public abstract class MediaBase
    {
        [JsonProperty("id")]
        public string? Id;

        [JsonProperty("link")]
        public string? Link;

        [JsonProperty("caption")]
        public string? Caption;

        [JsonProperty("filename")] 
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
