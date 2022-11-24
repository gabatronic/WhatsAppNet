using Newtonsoft.Json;

namespace WhatsApp.Messages.Objects.Interactive
{
    public class InteractiveButton
    {
        [JsonProperty("type")]
        public string Type => "reply";

        [JsonProperty("title")]
        public string Title;

        [JsonProperty("id")]
        public string Id;

        public InteractiveButton(string title, string id) 
        { 
            Title = title;
            Id = id;
        }
    }
}
