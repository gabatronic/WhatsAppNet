using System.Text.Json.Serialization;
using WhatsApp.Intl;
using WhatsApp.Messages.Objects;

namespace WhatsApp.Messages
{
    public class MessageTemplate : MessageBase
    {
        private MessageTemplate(string to, Template template) : base("template", to) 
        {
            Template = template;
        }

        [JsonPropertyName("template")]
        public Template Template;

        public static MessageTemplate Create(string templateName, string to, Language? language = null)
        {
            var template = new Template(null, templateName, language);
            return new MessageTemplate(to, template);
        }        
    }
}
