using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public event EventHandler<ItemAddedEventArgs> ItemAdded;

        private void OnSubmitButtonClick(object sender, EventArgs e)
        {
            if (ItemAdded != null)
            {

                var args = new ItemAddedEventArgs(
                    issue: textBoxIssue.Text,
                    comment: textBoxComment.Text);
                ItemAdded(this, args);
                this.textBoxComment.Clear();
                this.textBoxIssue.Clear();
            }
        }
    }
}
