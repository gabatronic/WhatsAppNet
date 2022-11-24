using Newtonsoft.Json;
using WhatsApp.Messages.Objects.Media;

namespace WhatsApp.Messages.Objects.Interactive
{

    public class DocumentHeader : InteractiveHeader
    {
        [JsonProperty("document")]
        public Document Document;

        protected DocumentHeader(Document document) : base("document")
        {
            Document = document;
        }

        public static DocumentHeader CreateFromUrl(string url, string? captionOrTitle = null)
        {
            return new DocumentHeader(Document.FromUrl(url, captionOrTitle));
        }

        public static DocumentHeader CreateFromId(string id, string? captionOrTitle = null)
        {
            return new DocumentHeader(Document.FromId(id, captionOrTitle));
        }
    }
}
