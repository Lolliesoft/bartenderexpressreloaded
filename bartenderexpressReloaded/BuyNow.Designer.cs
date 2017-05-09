namespace bartenderexpressReloaded
{
    partial class BuyNow
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
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser4
            // 
            this.webBrowser4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser4.Location = new System.Drawing.Point(0, 0);
            this.webBrowser4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.ScriptErrorsSuppressed = true;
            this.webBrowser4.Size = new System.Drawing.Size(212, 207);
            this.webBrowser4.TabIndex = 0;
            this.webBrowser4.Url = new System.Uri("https://www.lolliesoft.com/shop/", System.UriKind.Absolute);
            // 
            // BuyNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 207);
            this.Controls.Add(this.webBrowser4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuyNow";
            this.Text = "Purchase BartenderExpress Pro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser4;
    }
}