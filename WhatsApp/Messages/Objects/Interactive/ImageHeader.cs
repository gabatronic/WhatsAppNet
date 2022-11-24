using Newtonsoft.Json;
using WhatsApp.Messages.Objects.Media;

namespace WhatsApp.Messages.Objects.Interactive
{
    public class ImageHeader : InteractiveHeader
    {
        [JsonProperty("image")]
        public Image Image;
        protected ImageHeader(Image image) : base("image")
        {
            Image = image;
        }

        public static ImageHeader CreateFromUrl(string url, string? captionOrTitle = null)
        {
            return new ImageHeader(Image.FromUrl(url, captionOrTitle));
        }

        public static ImageHeader CreateFromId(string id, string? captionOrTitle = null)
        {
            return new ImageHeader(Image.FromId(id, captionOrTitle));
        }
    }
}
