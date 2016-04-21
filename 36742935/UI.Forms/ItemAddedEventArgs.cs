using System;

namespace UI.Forms
{
    public class ItemAddedEventArgs : EventArgs
    {
        public ItemAddedEventArgs(string issue, string comment)
        {
            this.Issue = issue;
            this.Comment = comment;
        }

        public string Issue { get; private set; }

        public string Comment { get; private set; }
    }
}