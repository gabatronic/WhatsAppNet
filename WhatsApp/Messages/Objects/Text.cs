using Newtonsoft.Json;

namespace WhatsApp.Messages.Object
{
    public class Text
    {
        [JsonProperty("body")]
        public string Body { get; }

        [JsonProperty("preview_url")]
        public bool PreviewUrl { get;  }

        public Text(string body, bool previewUrl = false)
        {
            Body = body;
            PreviewUrl = previewUrl;
        }
    }
}
