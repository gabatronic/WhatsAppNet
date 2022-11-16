using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Messages.Objects.Components
{
    public class HeaderComponent : Component
    {
        public HeaderComponent() : base("header") { }

        public override void SetText(int index, string text)
        {
            if (text.Length > 60)
            {
                throw new ArgumentException("Header's parameters text can't be larger than 60 characters");
            }

            base.SetText(index, text);
        }
    }
}
