using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    
    public partial class FavoriteForm : Form
    {
        public string FavAddr { get; set; }
        public FavoriteForm()
        {
            InitializeComponent();
        }

        private void FavSefAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.listBox1.Items.Add(this.FavSefAdd.Text);
                this.FavSefAdd.Text = "";
            }
        }

        private void FavoriteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
