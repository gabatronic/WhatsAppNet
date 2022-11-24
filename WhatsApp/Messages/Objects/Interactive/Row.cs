using Newtonsoft.Json;

namespace WhatsApp.Messages.Objects.Interactive
{
    public class Row
    {
        [JsonProperty("id")]
        public string? Id;

        [JsonProperty("title")]
        public string? Title;

        [JsonProperty("description")]
        public string? Description;

        public Row(string? id, string? title, string? description) 
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }
}
