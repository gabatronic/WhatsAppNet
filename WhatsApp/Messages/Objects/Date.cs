using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsApp.Messages.Objects.Components;

namespace WhatsApp.Messages.Objects
{
    public class Date
    {
        public string FallbackValue;

        public Date(string fallbackValue)
        {
            FallbackValue = fallbackValue;
        }
    }
}
