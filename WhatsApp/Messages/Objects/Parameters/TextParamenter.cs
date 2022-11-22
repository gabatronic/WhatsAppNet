using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Messages.Objects.Parameters
{
    public class TextParamenter : ParameterBase
    {   
        public TextParamenter(string text) : base("text") 
        { 
            Text = text;
        }

        [JsonProperty("text")]
        public string Text { get; }
    }
}
