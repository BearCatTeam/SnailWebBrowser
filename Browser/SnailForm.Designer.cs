namespace Browser
{
    partial class SnailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnailForm));
            this.Backward = new System.Windows.Forms.Button();
            this.Fordward = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.LookFav = new System.Windows.Forms.Button();
            this.Favorite = new System.Windows.Forms.Button();
            this.SnailBrowser = new System.Windows.Forms.WebBrowser();
            this.addressBar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Backward
            // 
            this.Backward.BackColor = System.Drawing.SystemColors.ControlText;
            this.Backward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Backward.BackgroundImage")));
            this.Backward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Backward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Backward.Location = new System.Drawing.Point(4, 17);
            this.Backward.Margin = new System.Windows.Forms.Padding(4);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(53, 41);
            this.Backward.TabIndex = 0;
            this.Backward.UseVisualStyleBackColor = false;
            this.Backward.Click += new System.EventHandler(this.Backward_Click);
            // 
            // Fordward
            // 
            this.Fordward.BackColor = System.Drawing.SystemColors.ControlText;
            this.Fordward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fordward.BackgroundImage")));
            this.Fordward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fordward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fordward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fordward.Location = new System.Drawing.Point(37, 17);
            this.Fordward.Margin = new System.Windows.Forms.Padding(4);
            this.Fordward.Name = "Fordward";
            this.Fordward.Size = new System.Drawing.Size(53, 41);
            this.Fordward.TabIndex = 1;
            this.Fordward.UseVisualStyleBackColor = false;
            this.Fordward.Click += new System.EventHandler(this.Fordward_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.SystemColors.ControlText;
            this.Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh.BackgroundImage")));
            this.Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Refresh.Location = new System.Drawing.Point(81, 12);
            this.Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(51, 52);
            this.Refresh.TabIndex = 2;
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // LookFav
            // 
            this.LookFav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LookFav.BackColor = System.Drawing.SystemColors.ControlText;
            this.LookFav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LookFav.BackgroundImage")));
            this.LookFav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LookFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LookFav.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LookFav.Location = new System.Drawing.Point(933, 20);
            this.LookFav.Margin = new System.Windows.Forms.Padding(4);
            this.LookFav.Name = "LookFav";
            this.LookFav.Size = new System.Drawing.Size(48, 41);
            this.LookFav.TabIndex = 3;
            this.LookFav.UseVisualStyleBackColor = false;
            this.LookFav.Click += new System.EventHandler(this.LookFav_Click);
            // 
            // Favorite
            // 
            this.Favorite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Favorite.BackColor = System.Drawing.SystemColors.ControlText;
            this.Favorite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Favorite.BackgroundImage")));
            this.Favorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Favorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Favorite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Favorite.Location = new System.Drawing.Point(876, 15);
            this.Favorite.Margin = new System.Windows.Forms.Padding(4);
            this.Favorite.Name = "Favorite";
            this.Favorite.Size = new System.Drawing.Size(45, 49);
            this.Favorite.TabIndex = 5;
            this.Favorite.UseVisualStyleBackColor = false;
            this.Favorite.Click += new System.EventHandler(this.Favorite_Click);
            // 
            // SnailBrowser
            // 
            this.SnailBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SnailBrowser.Location = new System.Drawing.Point(0, 71);
            this.SnailBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.SnailBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.SnailBrowser.Name = "SnailBrowser";
            this.SnailBrowser.Size = new System.Drawing.Size(997, 334);
            this.SnailBrowser.TabIndex = 6;
            this.SnailBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.SnailBrowser_DocumentCompleted);
            // 
            // addressBar
            // 
            this.addressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBar.Location = new System.Drawing.Point(139, 22);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(730, 30);
            this.addressBar.TabIndex = 7;
            this.addressBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressBar_KeyPress);
            // 
            // SnailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(997, 406);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.SnailBrowser);
            this.Controls.Add(this.Favorite);
            this.Controls.Add(this.LookFav);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Fordward);
            this.Controls.Add(this.Backward);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SnailForm";
            this.Text = "Snail -Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backward;
        private System.Windows.Forms.Button Fordward;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button LookFav;
        private System.Windows.Forms.Button Favorite;
        private System.Windows.Forms.WebBrowser SnailBrowser;
        private System.Windows.Forms.TextBox addressBar;
    }
}

