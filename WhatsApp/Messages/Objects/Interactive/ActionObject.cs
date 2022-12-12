using Newtonsoft.Json;

namespace WhatsApp.Messages.Objects.Interactive
{
    public class ActionObject
    {
        protected ActionObject(string? button, IEnumerable<InteractiveButton>? buttons, string? catalogId, string? productRetailerId, IEnumerable<Section>? sections) 
        {
            Button = button;
            Buttons = buttons;
            CatalogId = catalogId;
            ProductRetailerId = productRetailerId;
            Sections = sections;
        }

        [JsonProperty("button")]
        public string? Button;
        
        [JsonProperty("buttons")]
        public IEnumerable<InteractiveButton>? Buttons;

        [JsonProperty("catalog_id")]
        public string? CatalogId;
        
        [JsonProperty("product_retailer_id")] 
        public string? ProductRetailerId;

        [JsonProperty("sections")]
        public IEnumerable<Section>? Sections;

        public static ActionObject ProductButton(string catalogId, string productId)
        {
            return new ActionObject(null, null, catalogId, productId, null);
        }

        public static ActionObject ProductList(string catalogId, IEnumerable<Section> sections)
        {
            return new ActionObject(null, null, catalogId, null, sections);
        }

        public static ActionObject MessageList(IEnumerable<Section> sections)
        {
            return new ActionObject(null, null, null, null, sections);
        }

        public static ActionObject ButtonList(IEnumerable<InteractiveButton>? buttons)
        {
            return new ActionObject(null, buttons ?? new List<InteractiveButton>(), null, null, null);
        }

    }
}
