using Newtonsoft.Json;
using WhatsApp.Intl;
using WhatsApp.Messages.Objects.Components;

namespace WhatsApp.Messages.Objects
{
    public class Template
    {
        private IList<Component> components;
        public Template(string? @namespace, string name, Language? language = null)
        {
            Namespace = @namespace;
            Name = name;
            Language = language ?? Language.English;
            components = new List<Component>();
        }

        public string? Namespace { get; }

        [JsonProperty("name")]
        public string Name { get; }

        [JsonProperty("language")]
        public Language Language { get; }

        [JsonProperty("components")]
        public IEnumerable<Component> Components => components;

        [JsonIgnore]
        public HeaderComponent? Header => components.FirstOrDefault(c => c.Type == "header") as HeaderComponent;

        [JsonIgnore]
        public FooterComponent? Footer => components.FirstOrDefault(c => c.Type == "footer") as FooterComponent;

        [JsonIgnore]
        public BodyComponent? Body => components.FirstOrDefault(c => c.Type == "body") as BodyComponent;

        [JsonIgnore]
        public IEnumerable<ButtonComponent>? Buttons => components.Where(c => c.Type == "button")?.Cast<ButtonComponent>();

        public HeaderComponent AddHeader()
        {
            var header = new HeaderComponent();
            components.Add(header);
            return header;
        }

        public BodyComponent AddBody()
        {
            var body = new BodyComponent();
            components.Add(body);
            return body;
        }

        public FooterComponent AddFooter()
        {
            var footer = new FooterComponent();
            components.Add(footer);
            return footer;
        }

        public ButtonComponent AddReplyButton(int index, string text)
        {
            var button = ButtonComponent.CreateReply(0, text);
            components.Add(button);
            return button;
        }
        public ButtonComponent AddUrlTextButton(int index, string text)
        {
            var button = ButtonComponent.CreateText(index, text);
            components.Add(button);
            return button;
        }

    }
}
