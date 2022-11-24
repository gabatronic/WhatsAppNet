using Newtonsoft.Json;
using WhatsApp.Messages.Objects.Parameters;

namespace WhatsApp.Messages.Objects.Components
{
    public abstract class Component
    {
        private IDictionary<int, ParameterBase> parameters;
        protected Component(string type) 
        { 
            parameters = new Dictionary<int, ParameterBase>();
            Type = type.ToLower();
        }

        [JsonProperty("type")]
        public string Type { get; }

        [JsonProperty("parameters")]
        public IDictionary<int, ParameterBase> Parameters => parameters;

        public void SetParameter<T>(int index, T parameter) where T : ParameterBase
        {
            parameters[index] = parameter;
        }

        public void SetCurrency(int index, Currency currency)
        {
            SetParameter(index, new CurrencyParameter(currency));
        }

        public void SetCurrency(int index, double amount, Currency? currency = null)
        {
            if (currency == null)
            {
                currency = Currency.Euro;
            }
                
            currency.SetAmount(amount);
            SetParameter(index, new CurrencyParameter(currency));
        }

        public virtual void SetText(int index, string text)
        {
            SetParameter(index, new TextParameter(text));
        }

        public virtual void SetDate(int index, DateTime dateTime)
        {
            SetParameter(index, new DateParameter(new Date(dateTime)));
        }

        public void SetImageFromUrl(int index, string url)
        {
            var image = Objects.Media.Image.FromUrl(url);
            SetParameter(index, new ImageParameter(image));
        }

        public void SetImageFromId(int index, string id)
        {
            var image = Objects.Media.Image.FromId(id);
            SetParameter(index, new ImageParameter(image));
        }

        public void SetDocumentFromUrl(int index, string url)
        {
            var document = Objects.Media.Document.FromUrl(url);
            SetParameter(index, new DocumentParameter(document));
        }

        public void SetDocumentFromId(int index, string id)
        {
            var document = Objects.Media.Document.FromId(id);
            SetParameter(index, new DocumentParameter(document));
        }

        public void SetVideoFromUrl(int index, string url)
        {
            var video = Objects.Media.Video.FromUrl(url);
            SetParameter(index, new VideoParameter(video));
        }

        public void SetVideoFromId(int index, string id)
        {
            var video = Objects.Media.Video.FromId(id);
            SetParameter(index, new VideoParameter(video));
        }
    }
}
