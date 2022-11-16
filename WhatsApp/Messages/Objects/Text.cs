using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Messages.Object
{
    public class Text
    {
        public string Body { get; }

        public bool PreviewUrl { get;  }

        public Text(string body, bool previewUrl = false)
        {
            Body = body;
            PreviewUrl = previewUrl;
        }
    }
}
