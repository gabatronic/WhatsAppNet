using Newtonsoft.Json;

namespace WhatsApp.Messages.Objects.Contacts
{
    public class ContactName
    {
        public ContactName(string fullname, string? firstname, string? lastname, string? middlename, string? suffix, string? prefix)
        {
            if (string.IsNullOrWhiteSpace(fullname))
                throw new ArgumentNullException(nameof(fullname));
            
            if (string.IsNullOrWhiteSpace(firstname) && string.IsNullOrWhiteSpace(lastname) &&
                string.IsNullOrWhiteSpace(middlename) &&
                string.IsNullOrWhiteSpace(suffix) &&
                string.IsNullOrWhiteSpace(prefix))
                throw new ArgumentNullException("At least one of the optional parameters needs to be included along with the Fullname");
            
            FormattedName = fullname;
            FirstName = firstname;
            LastName = lastname;
            MiddleName = middlename;
            Suffix = suffix;
            Prefix = prefix;
        }
        
        [JsonProperty("formatted_name")]
        public string FormattedName;

        [JsonProperty("first_name")]
        public string? FirstName;

        [JsonProperty("last_name")]
        public string? LastName;

        [JsonProperty("middle_name")]
        public string? MiddleName;

        [JsonProperty("suffix")]
        public string? Suffix;

        [JsonProperty("prefix")]
        public string? Prefix;
    }
}
