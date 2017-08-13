namespace DxDockPanelSample.Data
{
    public class DocumentItem
    {
        private string _captionName;
        private string _text;

        public string CaptionName
        {
            get { return _captionName; }
            set { _captionName = value; }
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public DocumentItem(string captionName, string text)
        {
            CaptionName = captionName;
            Text = text;
        }
        public DocumentItem(string captionName)
        {
            CaptionName = captionName;
            Text = $"Sample Content for :({captionName})";
        }

        public DocumentItem() { }
    }
}
