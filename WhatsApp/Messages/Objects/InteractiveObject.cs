using Newtonsoft.Json;
using System.Data;
using WhatsApp.Messages.Objects.Interactive;
using WhatsApp.Messages.Objects.Parameters;

namespace WhatsApp.Messages.Objects
{
    public abstract class InteractiveObject
    {
        [JsonProperty("type")]
        public string Type;

        [JsonProperty("body")]
        public TextParameter? Body;

        [JsonProperty("footer")]
        public TextParameter? Footer;

        [JsonProperty("action")]
        public ActionObject? Action;

        protected InteractiveObject(string type, TextParameter? body = null, TextParameter? footer = null, ActionObject? action = null) 
        {
            Type = type;
            Body = body;
            Footer = footer;
            Action = action;
        }
    }

    public class SingleProduct : InteractiveObject
    {
        public SingleProduct(string catalogId, string productId, string? productDescription, string? footerText) 
            : base("product", 
                  !string.IsNullOrWhiteSpace(productDescription) ? new TextParameter(productDescription) : null,
                  !string.IsNullOrWhiteSpace(footerText) ? new TextParameter(footerText) : null,
                  ActionObject.ProductButton(catalogId, productId))
        {
        }

        public static SingleProduct Create(string catalogId, string productId, string? productDescription, string? footerText)
        {
            return new SingleProduct(catalogId, productId, productDescription, footerText);
        }
    }

    public class MultiProduct : InteractiveObject
    {
        private IList<Section> _sections;

        [JsonProperty("header")]
        public InteractiveHeader Header;
        
        public MultiProduct(InteractiveHeader header, string catalogId, string? bodyText, string? footerText = null) 
            : base("product_list",
                  !string.IsNullOrWhiteSpace(bodyText) ? new TextParameter(bodyText) : null, 
                  !string.IsNullOrWhiteSpace(footerText) ? new TextParameter(footerText) : null) 
        {
            Header = header;
            _sections = new List<Section>();
            Action = ActionObject.ProductList(catalogId, _sections);
        }

        public Section AddSection(string title, IEnumerable<string> productSkus)
        {
            var section = new Section
            {
                Title = title,
                ProductItems = productSkus
            };
            
            _sections.Add(section);
            return section;
        }
    }

    public class ListMessages : InteractiveObject
    {
        private IDictionary<string, Section> _sections;
        
        [JsonProperty("header")]
        public InteractiveHeader Header;

        public ListMessages(IList<Section> sections, InteractiveHeader header, string? bodyText = null, string? footerText = null)
            : base("list",
                  !string.IsNullOrWhiteSpace(bodyText) ? new TextParameter(bodyText) : null,
                  !string.IsNullOrWhiteSpace(footerText) ? new TextParameter(footerText) : null)
        {
            Header = header;
            _sections = new Dictionary<string, Section>();
        }

        public Row AddRow(string section, string id, string title, string description)
        {
            var row = new Row(id, title, description);
            Section? sec = !_sections.Any(s => s.Key == section) ? sec = new Section
            {
                Title = title,
                Rows = new List<Row>()
            } : _sections[section];
            
            sec.Rows?.Add(row);

            return row;
        }
    }
}
