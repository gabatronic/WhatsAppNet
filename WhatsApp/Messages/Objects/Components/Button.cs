using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Messages.Objects.Components
{
    public class Button : Component
    {

        protected Button(string type) : base("button")
        {
            SubType = type;
        }

        public string SubType;
        public string? Text;
        public string? Payload;
        public int Index;

        public static Button CreatePayload()
        {
            return new Button("payload");
        }

        public static Button CreateReply()
        {
            return new Button("text");
        }
    }
}
