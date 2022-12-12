using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Converters
{
    public class ReplyButtonConverter<T> : JsonConverter
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
            if (value is Tuple<string,string> reply)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("id");
                writer.WriteValue(reply.Item1);

                writer.WritePropertyName("title");
                writer.WriteValue(reply.Item2);
                writer.WriteEndObject();
            }
        }
    }
}
