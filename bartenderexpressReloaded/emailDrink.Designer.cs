﻿namespace bartenderexpressReloaded
{
    partial class emailDrink
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.sendEmail = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.ingredientsBox = new System.Windows.Forms.TextBox();
            this.directionsBox = new System.Windows.Forms.TextBox();
            this.amtIngBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(508, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(508, 20);
            this.textBox2.TabIndex = 3;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.Location = new System.Drawing.Point(109, 112);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(281, 211);
            this.webBrowser1.TabIndex = 4;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(393, 112);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScriptErrorsSuppressed = true;
            this.webBrowser2.ScrollBarsEnabled = false;
            this.webBrowser2.Size = new System.Drawing.Size(303, 211);
            this.webBrowser2.TabIndex = 5;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Location = new System.Drawing.Point(109, 329);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.ScriptErrorsSuppressed = true;
            this.webBrowser3.Size = new System.Drawing.Size(587, 96);
            this.webBrowser3.TabIndex = 6;
            // 
            // sendEmail
            // 
            this.sendEmail.Location = new System.Drawing.Point(623, 40);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(73, 45);
            this.sendEmail.TabIndex = 7;
            this.sendEmail.Text = "Send Drink";
            this.sendEmail.UseVisualStyleBackColor = true;
            this.sendEmail.Click += new System.EventHandler(this.SendEmail_Click);
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(12, 112);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(77, 20);
            this.amountBox.TabIndex = 8;
            this.amountBox.Visible = false;
            // 
            // ingredientsBox
            // 
            this.ingredientsBox.Location = new System.Drawing.Point(13, 139);
            this.ingredientsBox.Name = "ingredientsBox";
            this.ingredientsBox.Size = new System.Drawing.Size(77, 20);
            this.ingredientsBox.TabIndex = 9;
            this.ingredientsBox.Visible = false;
            // 
            // directionsBox
            // 
            this.directionsBox.Location = new System.Drawing.Point(12, 212);
            this.directionsBox.Name = "directionsBox";
            this.directionsBox.Size = new System.Drawing.Size(77, 20);
            this.directionsBox.TabIndex = 10;
            this.directionsBox.Visible = false;
            // 
            // amtIngBox
            // 
            this.amtIngBox.Location = new System.Drawing.Point(13, 178);
            this.amtIngBox.Name = "amtIngBox";
            this.amtIngBox.Size = new System.Drawing.Size(77, 20);
            this.amtIngBox.TabIndex = 11;
            this.amtIngBox.Visible = false;
            // 
            // emailDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amtIngBox);
            this.Controls.Add(this.directionsBox);
            this.Controls.Add(this.ingredientsBox);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.sendEmail);
            this.Controls.Add(this.webBrowser3);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "emailDrink";
            this.Text = "email Drink Recipe";
            this.Click += new System.EventHandler(this.SendEmail_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.WebBrowser webBrowser1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.WebBrowser webBrowser2;
        public System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.Button sendEmail;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.TextBox ingredientsBox;
        private System.Windows.Forms.TextBox directionsBox;
        private System.Windows.Forms.TextBox amtIngBox;
    }
}