using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Messages.Objects.Contacts
{
    public class Organization
    {
        public Organization(string? company, string? deparment, string? title) 
        {
            Company = company;
            Department = deparment;
            Title = title;
        }

        [JsonProperty("company")]
        public string? Company;

        [JsonProperty("deparment")]
        public string? Department;

        [JsonProperty("title")]
        public string? Title;
    }
}
