using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WhatsApp.Messages.Objects
{
    public class Currency
    {
        [JsonIgnore] public static Currency Euro => new Currency("EUR");

        [JsonIgnore] public static Currency DollarUS => new Currency("USD");

        [JsonIgnore] public static Currency DollarCA => new Currency("CAD");

        [JsonIgnore] public static Currency DollarHK => new Currency("HKD");

        [JsonIgnore] public static Currency Pound => new Currency("GBP");

        [JsonIgnore] public static Currency Yuan => new Currency("CNY");

        [JsonIgnore] public static Currency FrancSW => new Currency("CHF");

        [JsonIgnore] public static Currency CrownDK => new Currency("DKK");

        [JsonIgnore] public static Currency Yen => new Currency("JPY");

        private Currency(string code, string fallback = "USD")
        {
            Code = code;
            FallbackValue = fallback;
        }

        [JsonPropertyName("fallback_vaue")]
        public string FallbackValue { get; }
        /// <summary>
        /// ISO 4217 currency code
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; }

        [JsonPropertyName("amount_1000")]
        public int Amount { get; }
    }
}
