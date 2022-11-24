using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Messages
{
    public class MessageContact : MessageBase
    {
        protected MessageContact(string to) : base("contacts", to) { }
    }
}
