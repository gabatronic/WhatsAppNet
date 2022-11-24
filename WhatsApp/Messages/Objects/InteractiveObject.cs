using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsApp.Messages.Objects.Parameters;

namespace WhatsApp.Messages.Objects
{
    public class InteractiveObject
    {
        [JsonProperty("type")]
        public string Type;

        [JsonProperty("body")]
        public TextParameter? Body;

        [JsonProperty("footer")]
        public TextParameter? Footer;

        

        public InteractiveObject(string type, string? body = null, string? footer) 
        {
            Type = type;
            
            if (body != null)
            {
                Body = new TextParameter(body);
            }

            if (footer != null)
            {
                Footer = new TextParameter(footer);
            }

        }
    }
}
