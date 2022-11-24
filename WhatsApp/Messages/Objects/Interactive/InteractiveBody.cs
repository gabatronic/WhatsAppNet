using Newtonsoft.Json;

namespace WhatsApp.Messages.Objects.Interactive
{
    public class InteractiveBody
    {
        [JsonProperty("text")]
        public string Text;

        public InteractiveBody(string text) 
        { 
            Text = text;
        }
    }
}
