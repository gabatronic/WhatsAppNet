using Newtonsoft.Json;

namespace WhatsApp.Messages.Objects.Media
{
    public class Video : MediaBase
    {
        [JsonProperty("type")]
        public string Type => "video";

        private Video(string ? id = null, string ? link = null, string ? caption = null, string ? filename = null) : base (id, link, caption, filename)
        {
        }

        public static Video FromUrl(string url, string? caption = null) => new Video(null, url, caption);

        public static Video FromId(string id) => new Video(id);
    }
}
