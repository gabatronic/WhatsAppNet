namespace WhatsApp.Messages.Objects.Interactive
{
    public class TextHeader : InteractiveHeader
    {
        public string Text;
        public TextHeader(string text) : base("text")
        {
            Text = text;
        }
    }
}
