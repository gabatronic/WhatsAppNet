using Newtonsoft.Json;
using WhatsApp.Messages.Objects.Interactive;
using WhatsApp.Messages.Objects.Parameters;

namespace WhatsApp.Messages.Objects
{
    public abstract class InteractiveObject
    {
        [JsonProperty("type")]
        public string Type;

        [JsonProperty("body")]
        public TextParameter? Body;

        [JsonProperty("footer")]
        public TextParameter? Footer;

        [JsonProperty("action")]
        public ActionObject? Action;

        protected InteractiveObject(string type, TextParameter? body = null, TextParameter? footer = null, ActionObject? action) 
        {
            Type = type;
            Body = body;
            Footer = footer;
            Action = action;
        }
    }

    public class SingleProduct : InteractiveObject
    {
        public SingleProduct(string catalogId, string productId, string? productDescription, string? footerText) 
            : base("product", 
                  !string.IsNullOrWhiteSpace(productDescription) ? new TextParameter(productDescription) : null,
                  !string.IsNullOrWhiteSpace(footerText) ? new TextParameter(footerText) : null,
                  ActionObject.ProductButton(catalogId, productId))
        {
        }

        public static SingleProduct Create(string catalogId, string productId, string? productDescription, string? footerText)
        {
            return new SingleProduct(catalogId, productId, productDescription, footerText);
        }
    }

    public class MultiProduct : InteractiveObject
    {
        public MultiProduct(InteractiveHeader header, InteractiveBody body, IEnumerable<Section> sections)
            : base("product_list",
                  )
    }
}
