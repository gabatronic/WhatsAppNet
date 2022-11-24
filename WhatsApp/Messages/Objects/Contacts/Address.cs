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
        public Address(string? street, string? city, string? state, string? postalCode, string? country, string? countryCode?, string? type) 
        { 
            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
            CountryCode = countryCode;
            Type = type;
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
