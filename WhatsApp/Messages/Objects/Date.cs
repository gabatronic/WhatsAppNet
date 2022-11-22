using Newtonsoft.Json;
using System;
using System.Globalization;

namespace WhatsApp.Messages.Objects
{
    public class Date
    {
        [JsonProperty("fallback_value")]
        public string FallbackValue;

        public Date(DateTime date)
        {
            FallbackValue = date.ToString("MMMM dd, yyyy", new CultureInfo("en-US"));
        }
    }
}
