using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Messages
{
    public class MessageInteractive : MessageBase
    {
        public MessageInteractive(string to) : base("interactive", to)
        {

        }
    }
}
