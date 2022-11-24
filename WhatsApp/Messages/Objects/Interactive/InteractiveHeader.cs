using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsApp.Messages.Objects.Media;

namespace WhatsApp.Messages.Objects.Interactive
{
    public abstract class InteractiveHeader
    {
        public string Type;
        protected InteractiveHeader(string type)
        {
            Type = type;
        }        
    }
}
