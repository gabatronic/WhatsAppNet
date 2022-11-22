using Newtonsoft.Json;
using WhatsApp.Messages.Objects.Media;

namespace WhatsApp.Messages.Objects.Parameters
{
    public class ImageParameter : ParameterBase
    {
        public ImageParameter(Image media) : base ("image") 
        { 
            Image = media;            
        }

        [JsonProperty("image")]
        public Image Image;
    }
}
