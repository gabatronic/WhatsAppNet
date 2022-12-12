using Newtonsoft.Json;
using WhatsApp.Converters;

namespace WhatsApp.Messages.Objects.Interactive
{
    public class InteractiveButton
    {
        [JsonProperty("type")]
        public string Type => "reply";

        [JsonProperty("reply")]        
        [JsonConverter(typeof(ReplyButtonConverter<Tuple<string, string>>))]
        public Tuple<string, string> Reply;
        

        public InteractiveButton(string title, string id)         
        {
            Reply = Tuple.Create(id, title);            
        }
    }
}
