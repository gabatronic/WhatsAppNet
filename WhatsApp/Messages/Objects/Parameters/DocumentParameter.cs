using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsApp.Messages.Objects.Media;

namespace WhatsApp.Messages.Objects.Parameters
{
    public class DocumentParameter : ParameterBase
    {
        public DocumentParameter(MediaBase document) : base("document")
        {
            Document = document;
        }

        public MediaBase Document;
    }
}
