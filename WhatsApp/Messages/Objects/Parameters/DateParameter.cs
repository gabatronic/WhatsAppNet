using System.Text.Json.Serialization;

namespace WhatsApp.Messages.Objects.Parameters
{
    public class DateParameter : ParameterBase
    {
        public DateParameter(Date dateTime) : base("date_time")
        {
            Date = dateTime;
        }

        [JsonPropertyName("date_time")]
        public Date Date;
    }
}
