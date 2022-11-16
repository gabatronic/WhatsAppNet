using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Messages.Objects.Parameters
{
    public abstract class ParameterBase
    {
        public string Type { get; }

        public ParameterBase(string type)
        {
            Type = type;
        }
    }
}
