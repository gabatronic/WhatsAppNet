using Newtonsoft.Json;

namespace WhatsApp.Messages.Objects.Parameters
{
    public class DateParameter : ParameterBase
    {
        public DateParameter(Date dateTime) : base("date_time")
        {
            Date = dateTime;
        }

        [JsonProperty("date_time")]
        public Date Date;
    }
}
