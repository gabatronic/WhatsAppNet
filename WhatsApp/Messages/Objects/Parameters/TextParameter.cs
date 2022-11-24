using Newtonsoft.Json;

namespace WhatsApp.Messages.Objects.Parameters
{
    public class TextParameter : ParameterBase
    {   
        public TextParameter(string text) : base("text") 
        { 
            Text = text;
        }

        [JsonProperty("text")]
        public string Text { get; }
    }
}
