using Newtonsoft.Json;

namespace WhatsApp.Messages.Objects.Media
{
    public class Image : MediaBase
    {
        [JsonProperty("type")]
        public string Type => "image";

        private Image(string? id = null, string? link = null, string? caption = null, string? filename = null) : base (id, link, caption, filename)
        {
        }

        public static Image FromUrl(string url, string? caption = null) => new Image(null, url, caption);

        public static Image FromId(string id) => new Image(id);        
    }
}
