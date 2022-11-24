using Newtonsoft.Json;

namespace WhatsApp.Messages.Objects.Contacts
{
    public class Email
    {
        public Email(string? email, string? type) 
        { 
            EmailAddress = email;
            Type = type;
        }

        [JsonProperty("email")]
        public string? EmailAddress;

        [JsonProperty("type")]
        public string? Type;
    }
}
