using Newtonsoft.Json;
using WhatsApp.Messages.Objects.Media;

namespace WhatsApp.Messages.Objects.Parameters
{
    public class VideoParameter : ParameterBase
    {
        [JsonProperty("video")]
        public Video Video;
        
        public VideoParameter(Video video) : base("video")
        {
            Video = video;
        }
    }
}
