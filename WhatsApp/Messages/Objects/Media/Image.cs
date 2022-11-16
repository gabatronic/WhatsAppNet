using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Messages.Objects.Media
{
    public class Image : MediaBase
    {
        public string Type => "image";


        private Image(string? id = null, string? link = null, string? caption = null, string? filename = null) : base (id, link, caption, filename)
        {
        }

        public static Image FromUrl(string url, string? caption = null) => new Image(null, url, caption);

        public static Image FromId(string id) => new Image(id);        
    }
}
