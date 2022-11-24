using Newtonsoft.Json;

namespace WhatsApp.Converters
{
    public class ProductItemSerializer<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IEnumerable<string>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is IEnumerable<string> list)
            {
                writer.WriteStartArray();
                foreach (var item in list)
                {
                    if (!string.IsNullOrWhiteSpace(item))
                    {
                        writer.WriteStartObject();
                        writer.WritePropertyName("product_item_id");
                        writer.WriteValue(item);
                        writer.WriteEndObject();
                    }
                }
                writer.WriteEndArray();
            }
        }
    }
}
