using Newtonsoft.Json;
using WhatsApp.Converters;

namespace WhatsApp.Messages.Objects.Interactive
{
    public class Section
    {
        [JsonProperty("title")]
        public string? Title;

        [JsonProperty("rows")]
        public IList<Row>? Rows;

        [JsonProperty("product_items")]
        [JsonConverter(typeof(ProductItemSerializer<IEnumerable<string>>))]
        public IEnumerable<string>? ProductItems;
    }
}
