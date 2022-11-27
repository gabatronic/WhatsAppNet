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
    }
}
