using Newtonsoft.Json;
using WhatsApp.Messages.Objects.Parameters;

namespace WhatsApp.Messages.Objects.Components
{
    public class ButtonComponent : Component
    {

        protected ButtonComponent(string type, int index, ParameterBase button) : base("button")
        {
            SubType = type;                        
            Index = index;
            Parameters.Add(0, button);
        }

        [JsonProperty("sub_type")]
        public string SubType;

        [JsonProperty("index")]
        public int Index;

        public static ButtonComponent CreateReply(int index, string payloadReply)
        {
            return new ButtonComponent("quick_reply", index, new ButtonComponentReply(payloadReply));
        }

        public static ButtonComponent CreateText(int index, string text)
        {
            return new ButtonComponent("text", index, new ButtonComponentText(text));
        }

    }
    
    public class ButtonComponentReply : ParameterBase
    {
        public ButtonComponentReply(string payload) : base("payload") 
        { 
            Payload = payload;
        }

        [JsonProperty("payload")]
        public string Payload;
    }

    public class ButtonComponentText : ParameterBase
    {
        public ButtonComponentText(string text) : base("text")
        {
            Text = text;
        }
        
        [JsonProperty("text")]
        public string Text;
    }
}


