using Newtonsoft.Json;
using WhatsApp.Messages.Objects.Media;

namespace WhatsApp.Messages.Objects.Parameters
{
    public class DocumentParameter : ParameterBase
    {
        public DocumentParameter(MediaBase document) : base("document")
        {
            Document = document;
        }

        [JsonProperty("document")]
        public MediaBase Document;
    }
}
