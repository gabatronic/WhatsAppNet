using System.Text.Json.Serialization;

namespace WhatsApp.Messages.Objects.Parameters
{
    public class CurrencyParameter : ParameterBase
    {
        public CurrencyParameter(Currency currency) : base ("currency") 
        {
            Currency = currency;
        }

        [JsonPropertyName("currency")]
        public Currency Currency { get; }        
    }
}
