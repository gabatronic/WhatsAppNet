using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Messages.Objects.Media
{
    public class Video : MediaBase
    {
        public string Type => "video";

        private Video(string ? id = null, string ? link = null, string ? caption = null, string ? filename = null) : base (id, link, caption, filename)
        {
        }

        public static Video FromUrl(string url, string? caption = null) => new Video(null, url, caption);

        public static Video FromId(string id) => new Video(id);
    }
}
