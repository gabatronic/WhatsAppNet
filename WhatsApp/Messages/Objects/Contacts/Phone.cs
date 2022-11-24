using Newtonsoft.Json;

namespace WhatsApp.Messages.Objects.Contacts
{
    public class Phone
    {
        protected Phone(string? phoneNumber, string? type, string? whatsappId) 
        { 
            PhoneNumber = phoneNumber;
            Type = type;
            WhatsappId = whatsappId;
        }

        public static Phone WorkPhone(string number, string? whatsappId = null) 
        {
            return new Phone(number, PhoneType.Work.ToString().ToLower(), whatsappId);
        }

        public static Phone HomePhone(string number, string? whatsappId = null)
        {
            return new Phone(number, PhoneType.Home.ToString().ToLower(), whatsappId);
        }

        public static Phone CellPhone(string number, string? whatsappId = null)
        {
            return new Phone(number, PhoneType.Cell.ToString().ToLower(), whatsappId);
        }

        public static Phone iPhone(string number, string? whatsappId = null)
        {
            return new Phone(number, PhoneType.iPhone.ToString().ToLower(), whatsappId);
        }
        public Phone (string number, string? whatsappId = null)
        {
            PhoneNumber = number;
            WhatsappId = whatsappId;
            Type = PhoneType.Main.ToString().ToLower();
        }


        [JsonProperty("phone")]
        public string? PhoneNumber;

        [JsonProperty("typo")]
        public string? Type;

        [JsonProperty("wa_id")]
        public string? WhatsappId;
    }
}
