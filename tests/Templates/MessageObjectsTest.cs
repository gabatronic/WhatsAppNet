using Newtonsoft.Json;
using WhatsApp.Intl;
using WhatsApp.Messages;
using WhatsApp.Messages.Objects;
using WhatsApp.Messages.Objects.Parameters;
using Xunit;

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

        [Fact]
        public void Template()
        {
            var message = MessageTemplate.Create("hello_world", "644282911", Language.Spanish);
            var header = message.Template.AddHeader();
            header.SetText(0, "hola");
            header.SetImageFromUrl(1, "https://me.img/yo.jpg");
            
            var body = message.Template.AddBody();
            body.SetText(0, "cuerpo");
            body.SetCurrency(1, 1000, Currency.Euro);
            body.SetDate(2, DateTime.Today);
            message.Template.AddReplyButton(0, "hola b");
            message.Template.AddUrlTextButton(0, "text b");

            string output = JsonConvert.SerializeObject(message);
            int i = output.Length;
        }
    }
}