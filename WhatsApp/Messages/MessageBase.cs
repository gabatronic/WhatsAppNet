using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WhatsApp.Messages
{
    public abstract class MessageBase
    {
        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("to")]
        public string To { get; }

        protected MessageBase(string type, string to)
        {
            this.Type = type;
            this.To = to;   
        }

        [JsonPropertyName("recipient_type")]
        public string RecipientType => "individual";
    }
}
