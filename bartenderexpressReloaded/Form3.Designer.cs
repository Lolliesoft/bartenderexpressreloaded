﻿namespace bartenderexpressReloaded
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.Ingredients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FavoritesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Amount});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(225, 349);
            this.listView1.TabIndex = 1;
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
            this.listView2.TabIndex = 2;
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
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // FavoritesButton
            // 
            this.FavoritesButton.ForeColor = System.Drawing.Color.Black;
            this.FavoritesButton.Image = ((System.Drawing.Image)(resources.GetObject("FavoritesButton.Image")));
            this.FavoritesButton.Location = new System.Drawing.Point(542, 0);
            this.FavoritesButton.Name = "FavoritesButton";
            this.FavoritesButton.Size = new System.Drawing.Size(23, 23);
            this.FavoritesButton.TabIndex = 7;
            this.FavoritesButton.Tag = "Add to Favorites";
            this.FavoritesButton.Text = "FavoritesButton";
            this.FavoritesButton.UseVisualStyleBackColor = true;
            this.FavoritesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 560);
            this.Controls.Add(this.FavoritesButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Amount;
        protected internal System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader Ingredients;
        protected internal System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Button FavoritesButton;


    }
}