using Newtonsoft.Json;
using WhatsApp.Messages.Objects;
using WhatsApp.Messages.Objects.Interactive;

namespace WhatsApp.Messages
{
    public abstract class MessageInteractive : MessageBase
    {
        [JsonProperty("interactive")]
        public InteractiveObject Interactive;

        protected MessageInteractive(string to, InteractiveObject interactive) : base("interactive", to)
        {
            Interactive = interactive;
        }
    }

    public class MessageProduct : MessageInteractive
    {
        public MessageProduct(string to, string catalgoId, string productId, string description, string? footerText = null)
             : base(to, new SingleProduct(catalgoId, productId, description, footerText))
        {   
        }
    }

    public class MessageMultiProduct : MessageInteractive
    {
        public MessageMultiProduct(string to, string catalogId, string headerText, string? bodyText, string? footerText = null)
            : base (to, new MultiProduct(new TextHeader(headerText), catalogId, bodyText, footerText))
        {            
        }
    }
}
