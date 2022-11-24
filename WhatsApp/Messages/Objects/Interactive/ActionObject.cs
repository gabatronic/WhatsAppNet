using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Messages.Objects.Interactive
{
    public class ActionObject
    {
        [JsonProperty("button")]
        public string? Button;
        
        [JsonProperty("buttons")]
        public IEnumerable<InteractiveButton>? Buttons;

        [JsonProperty("catalog_id")]
        public string? CatalogId;
        
        [JsonProperty("product_retailer_id")] 
        public string? ProductRetailerId;        
    }
}
