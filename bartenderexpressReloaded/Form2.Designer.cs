﻿namespace bartenderexpressReloaded
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.Ingredients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DrinkBox = new System.Windows.Forms.PictureBox();
            this.DrinkTextBox = new System.Windows.Forms.TextBox();
            this.FavoritesDrinkButton = new System.Windows.Forms.Button();
            this.toolStripStatusLabel = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Amount});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(-2, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(225, 349);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 220;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ingredients});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(220, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(345, 349);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // Ingredients
            // 
            this.Ingredients.Text = "Ingredients";
            this.Ingredients.Width = 340;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-2, 348);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(567, 208);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // DrinkBox
            // 
            this.DrinkBox.Location = new System.Drawing.Point(10, 354);
            this.DrinkBox.Name = "DrinkBox";
            this.DrinkBox.Size = new System.Drawing.Size(200, 223);
            this.DrinkBox.TabIndex = 4;
            this.DrinkBox.TabStop = false;
            // 
            // DrinkTextBox
            // 
            this.DrinkTextBox.Location = new System.Drawing.Point(220, 355);
            this.DrinkTextBox.Multiline = true;
            this.DrinkTextBox.Name = "DrinkTextBox";
            this.DrinkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DrinkTextBox.Size = new System.Drawing.Size(345, 222);
            this.DrinkTextBox.TabIndex = 5;
            // 
            // FavoritesDrinkButton
            // 
            this.FavoritesDrinkButton.ForeColor = System.Drawing.Color.Black;
            this.FavoritesDrinkButton.Image = ((System.Drawing.Image)(resources.GetObject("FavoritesDrinkButton.Image")));
            this.FavoritesDrinkButton.Location = new System.Drawing.Point(542, 0);
            this.FavoritesDrinkButton.Name = "FavoritesDrinkButton";
            this.FavoritesDrinkButton.Size = new System.Drawing.Size(23, 23);
            this.FavoritesDrinkButton.TabIndex = 6;
            this.FavoritesDrinkButton.Tag = "Add to Favorites";
            this.FavoritesDrinkButton.Text = "button1";
            this.FavoritesDrinkButton.UseVisualStyleBackColor = true;
            this.FavoritesDrinkButton.Click += new System.EventHandler(this.FavoritesDrinkButton_Click);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Location = new System.Drawing.Point(0, 557);
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(568, 22);
            this.toolStripStatusLabel.TabIndex = 7;
            this.toolStripStatusLabel.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 579);
            this.Controls.Add(this.toolStripStatusLabel);
            this.Controls.Add(this.FavoritesDrinkButton);
            this.Controls.Add(this.DrinkTextBox);
            this.Controls.Add(this.DrinkBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form2";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DrinkBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.ListView listView2;
        protected internal System.Windows.Forms.ListView listView1;
        protected internal System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Ingredients;
        public System.Windows.Forms.PictureBox DrinkBox;
        public System.Windows.Forms.TextBox DrinkTextBox;
        protected internal System.Windows.Forms.Button FavoritesDrinkButton;
        public System.Windows.Forms.StatusStrip toolStripStatusLabel;
    }
}