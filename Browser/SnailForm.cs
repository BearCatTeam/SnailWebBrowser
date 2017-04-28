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
    public partial class SnailForm : Form
    {
        private FavoriteForm Bookmark;

        public SnailForm()
        {
            InitializeComponent();
            Bookmark = new FavoriteForm();
            this.Bookmark.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FavoriteForm_listBox1_MouseDoubleClick);
        }

        private void Backward_Click(object sender, EventArgs e)
        {
            if (this.SnailBrowser.CanGoBack)
            {
                this.SnailBrowser.GoBack();
            }
        }

        private void Fordward_Click(object sender, EventArgs e)
        {
            if (this.SnailBrowser.CanGoForward)
            {
                this.SnailBrowser.GoForward();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.SnailBrowser.Refresh();
        }

        private void addressBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.SnailBrowser.Navigate(addressBar.Text);
            }
        }

        private void FavoriteForm_listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Bookmark.listBox1.SelectedItem != null)
            {
                this.addressBar.Text = this.Bookmark.listBox1.SelectedItem.ToString();
                this.SnailBrowser.Navigate(this.addressBar.Text);
                this.Bookmark.Visible = false;
            }
        }

        private void Favorite_Click(object sender, EventArgs e)
        {
            Bookmark.listBox1.Items.Add(this.addressBar.Text);
        }

        private void LookFav_Click(object sender, EventArgs e)
        {
             Bookmark.Show();
        }

        private void SnailBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.addressBar.Text = e.Url.ToString();
        }
    }
}
