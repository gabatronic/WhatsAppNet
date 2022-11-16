using System.Text.Json.Serialization;
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

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("language")]
        public Language Language { get; }

        [JsonPropertyName("components")]
        public IEnumerable<Component> Components => components;

        [JsonIgnore]
        public HeaderComponent? Header => components.FirstOrDefault(c => c.Type == "header") as HeaderComponent;

        [JsonIgnore]
        public FooterComponent? Footer => components.FirstOrDefault(c => c.Type == "footer") as FooterComponent;

        [JsonIgnore]
        public BodyComponent? Body => components.FirstOrDefault(c => c.Type == "body") as BodyComponent;

        [JsonIgnore]
        public IEnumerable<ButtonComponent>? Buttons => components.Where(c => c.Type == "button")?.Cast<ButtonComponent>();

    }
}
