using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Messages.Objects.Contacts
{
    public class Address
    {
        protected Address(string? street, string? city, string? state, string? postalCode, string? country, string? countryCode, string? type) 
        { 
            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
            CountryCode = countryCode;
            Type = type;
        }
        public static Address HomeAddress(string street, string? city, string? postalCode)
        {
            return new Address(street, city, null, postalCode, null, null, ContactType.Home.ToString().ToLower());
        }
        
        [JsonProperty("street")]
        public string? Street;

        [JsonProperty("city")]
        public string? City;

        [JsonProperty("zip")]
        public string? PostalCode;

        [JsonProperty("country")]
        public string? Country;

        [JsonProperty("state")]
        public string? State;

        [JsonProperty("country_code")]
        public string? CountryCode;

        [JsonProperty("type")]
        public string? Type;
    }
}
