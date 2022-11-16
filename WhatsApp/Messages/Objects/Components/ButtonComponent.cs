namespace WhatsApp.Messages.Objects.Components
{
    public class ButtonComponent : Component
    {

        protected ButtonComponent(string type, string? payload = null, string? replyText = null) : base("button")
        {
            SubType = type;
            Payload = payload;
            Text = replyText;
        }

        public string SubType;
        public string? Text;
        public string? Payload;
        public int Index;

        public static ButtonComponent CreatePayload(string payload)
        {
            return new ButtonComponent("payload", payload);
        }

        public static ButtonComponent CreateReply(string replyText)
        {
            return new ButtonComponent("text", null, replyText);
        }
    }
}
