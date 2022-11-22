using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Messages.Objects.Media
{
    internal class Document: MediaBase
    {
        [JsonProperty("type")]
        public string Type => "document";
        private Document(string? id = null, string? link = null, string? caption = null, string? filename = null) : base(id, link, caption, filename)
        {
        }

        public static Document FromUrl(string url, string? caption = null) => new Document(null, url, caption);

        public static Document FromId(string id) => new Document(id);
    }
}
