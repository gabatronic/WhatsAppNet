using Newtonsoft.Json;

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

        [JsonProperty("fallback_vaue")]
        public string FallbackValue { get; }
        /// <summary>
        /// ISO 4217 currency code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; }

        [JsonProperty("amount_1000")]
        public int Amount { get; private set; }

        public void SetAmount(double amount)
        {
            Amount = Convert.ToInt32(amount  * 1000);
        }
        public void SetAmount(decimal amount)
        {
            Amount = Convert.ToInt32(amount  * 1000);
        }
        public void SetAmount(float amount)
        {
            Amount = Convert.ToInt32(amount  * 1000);
        }
        public void SetAmount(long amount)
        {
            Amount = Convert.ToInt32(amount  * 1000);
        }
        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            
            var currA = obj as Currency;
            
            return currA?.Code == Code && currA?.Amount == this.Amount;
        }
    }
}
