using Newtonsoft.Json;

namespace WhatsApp.Messages
{
    public abstract class MessageBase
    {
        [JsonProperty("type")]
        public string Type { get; }

        [JsonProperty("to")]
        public string To { get; }

        protected MessageBase(string type, string to)
        {
            this.Type = type;
            this.To = to;   
        }

        [JsonProperty("recipient_type")]
        public string RecipientType => "individual";
    }
}
