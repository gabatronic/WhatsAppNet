using Newtonsoft.Json;

namespace WhatsApp.Messages.Objects.Contacts
{
    public class UrlContact
    {
        protected UrlContact(string? url, string? type) 
        { 
            Url = url;
            Type = type;
        }

        public UrlContact(string url)
        {
            Url = url;
        }

        public static UrlContact UrlWork(string url)
        {
            return new UrlContact(url, ContactType.Work.ToString().ToLower());
        }

        public static UrlContact UrlHome(string url)
        {
            return new UrlContact(url, ContactType.Home.ToString().ToLower());
        }

        [JsonProperty("url")]
        public string? Url;

        [JsonProperty("type")]
        public string? Type;
    }
}
