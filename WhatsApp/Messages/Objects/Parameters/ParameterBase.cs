using Newtonsoft.Json;

namespace WhatsApp.Messages.Objects.Parameters
{
    public abstract class ParameterBase
    {
        [JsonProperty("type")]
        public string Type { get; }

        public ParameterBase(string type)
        {
            Type = type;
        }
    }
}
