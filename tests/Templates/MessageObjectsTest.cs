using WhatsApp.Messages.Objects;
namespace Templates
{
    public class MessageObjectsTest
    {
        [Fact]
        public void CurrencyCodes()
        {
            var test = new Dictionary<string, Currency>()
            {
                {"EUR", Currency.Euro},
                {"USD", Currency.DollarUS},
                {"CAD", Currency.DollarCA},
                {"HKD", Currency.DollarHK},
                {"GBP", Currency.Pound},
            };
            
            foreach (var keyValuePair in test)
            {
                Assert.Equal(keyValuePair.Key, keyValuePair.Value.Code);
            }
        }
    }
}