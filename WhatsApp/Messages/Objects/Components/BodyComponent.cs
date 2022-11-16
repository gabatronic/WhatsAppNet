using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Messages.Objects.Components
{
    public class BodyComponent : Component
    {
        public BodyComponent() : base("body") { }

        public override void SetText(int index, string text)
        {
            if (Parameters.Count() > 1 && text.Length > 1024)
            {
                throw new ArgumentException("Body's parameters text can't be larger than 1024 if there are more than one paramenters");
            }

            if (text.Length > 32768)
            {
                throw new ArgumentException("Text paramenter length exceded");
            }

            base.SetText(index, text);
        }
    }
}
