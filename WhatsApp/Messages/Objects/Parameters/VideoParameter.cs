using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsApp.Messages.Objects.Media;

namespace WhatsApp.Messages.Objects.Parameters
{
    public class VideoParameter : ParameterBase
    {
        public Video Video;
        
        public VideoParameter(Video video) : base("video")
        {
            Video = video;
        }
    }
}
