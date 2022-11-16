using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WhatsApp.Messages.Objects.Parameters;

namespace WhatsApp.Messages.Objects.Components
{
    public abstract class Component
    {
        private IList<ParameterBase> parameters;
        protected Component(string type) 
        { 
            parameters = new List<ParameterBase>();
            Type = type.ToLower();
        }

        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("parameters")]
        public IEnumerable<ParameterBase> Parameters => parameters;

        public void SetParameter<T>(int index, T parameter) where T : ParameterBase
        {
            parameters[index] = parameter;
        }

        public void SetCurrency(int index, Currency currency)
        {
            SetParameter(index, new CurrencyParameter(currency));
        }

        public virtual void SetText(int index, string text)
        {
            SetParameter(index, new TextParamenter(text));
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
