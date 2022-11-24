using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsApp.Messages.Objects.Contacts;

namespace WhatsApp.Messages.Objects
{
    public class Contact
    {
        private readonly IList<Phone> phoneList;
        private readonly IList<UrlContact> urlList;
        private readonly IList<Email> emailList;
        private readonly IList<Address> addressList;
        
        [JsonProperty("addresses")]
        public IEnumerable<Address>? Addresses => addressList;

        [JsonProperty("birthday")]
        public string? Birthday;

        [JsonProperty("emails")]
        public IEnumerable<Email>? Emails => emailList;
        
        [JsonProperty("name")]
        public ContactName Name;

        [JsonProperty("org")]
        public Organization? Organization;

        [JsonProperty("phones")]
        public IEnumerable<Phone>? Phones => phoneList;

        [JsonProperty("urls")]
        public IEnumerable<UrlContact>? Urls => urlList;

        protected Contact(IEnumerable<Address>? addresses, string? birthday, IEnumerable<Email>? emails, ContactName name, Organization? organization, IEnumerable<Phone>? phones, IEnumerable<UrlContact>? urls)
        {
            addressList = addresses?.ToList() ?? new List<Address>();            
            Birthday = birthday;
            emailList = emails?.ToList() ?? new List<Email>();
            Name = name;
            Organization = organization;
            phoneList = phones?.ToList() ?? new List<Phone>();
            urlList = urls?.ToList() ?? new List<UrlContact>();
        }

        public Contact(string name, string firstname, string phoneNumber, DateTime? birthday = null)
        {
            Name = new ContactName(name, firstname, null, null, null, null);
            phoneList = new List<Phone>
            {
                Phone.CellPhone(phoneNumber)
            };
            addressList = new List<Address>();
            Birthday = birthday?.ToString("yyyy-mm-dd");
            emailList = new List<Email>();            
            Organization = null;            
            urlList = new List<UrlContact>();
        }

        public void AddPhone(Phone phone)
        {
            phoneList.Add(phone);
        }

        public void AddMobile(string number)
        {
            phoneList.Add(Phone.CellPhone(number));
        }

        public void AddHomePhone(string number)
        {
            phoneList.Add(Phone.HomePhone(number));
        }

        public void AddWorkPhone(string number)
        {
            phoneList.Add(Phone.WorkPhone(number));
        }

        public void AddAddress(Address address)
        {
            addressList.Add(address);
        }

        public virtual void AddHomeAddress(string street, string? city = null, string? postalCode = null)
        {
            addressList.Add(Address.HomeAddress(street, city, postalCode));
        }
    }
}
