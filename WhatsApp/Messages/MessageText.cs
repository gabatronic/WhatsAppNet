using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsApp.Messages.Object;

namespace WhatsApp.Messages
{
    public class MessageText : MessageBase
    {
        public MessageText(string to, string text, bool previewUrl) : base("text", to) 
        {
            Text = new Text(text, previewUrl);
        }

        [JsonProperty("text")]
        public Text Text;
    }
}
