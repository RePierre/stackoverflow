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
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();

            form2 = new Form2();
            this.form2.ItemAdded += this.OnItemAdded;
            this.form2.Disposed += (sender, args) => this.form2.ItemAdded -= this.OnItemAdded;
        }

        private void OnItemAdded(object sender, ItemAddedEventArgs e)
        {
            this.listView1.Items.Add(e.Comment, e.Issue);
        }

        private void OnAddButtonClick(object sender, EventArgs e)
        {
            this.form2.Show();
        }
    }
}
