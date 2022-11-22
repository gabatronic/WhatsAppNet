using Newtonsoft.Json;

namespace WhatsApp.Messages.Objects.Parameters
{
    public class CurrencyParameter : ParameterBase
    {
        public CurrencyParameter(Currency currency) : base ("currency") 
        {
            Currency = currency;
        }

        [JsonProperty("currency")]
        public Currency Currency { get; }        
    }
}
