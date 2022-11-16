using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsApp.Messages.Objects.Media;

namespace WhatsApp.Messages.Objects.Parameters
{
    public class ImageParameter : ParameterBase
    {
        public ImageParameter(Image media) : base ("image") 
        { 
            Image = media;            
        }

        public Image Image;
    }
}
