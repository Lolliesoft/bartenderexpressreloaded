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
            this.components = new System.ComponentModel.Container();
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
            this.bartenderExpressDataSet = new bartenderexpressReloaded.bartenderExpressDataSet();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipesTableAdapter = new bartenderexpressReloaded.bartenderExpressDataSetTableAdapters.recipesTableAdapter();
            this.valWeight = new System.Windows.Forms.TextBox();
            this.valDrinks = new System.Windows.Forms.TextBox();
            this.valHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBAC = new System.Windows.Forms.Label();
            this.lblAnalysis = new System.Windows.Forms.Label();
            this.lblAnalysis2 = new System.Windows.Forms.Label();
            this.lblAnalysis3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bartenderExpressDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
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
            this.toolStripStatusLabel.Size = new System.Drawing.Size(864, 22);
            this.toolStripStatusLabel.TabIndex = 7;
            this.toolStripStatusLabel.Visible = false;
            // 
            // bartenderExpressDataSet
            // 
            this.bartenderExpressDataSet.DataSetName = "bartenderExpressDataSet";
            this.bartenderExpressDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "recipes";
            this.recipesBindingSource.DataSource = this.bartenderExpressDataSet;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // valWeight
            // 
            this.valWeight.Location = new System.Drawing.Point(589, 36);
            this.valWeight.Name = "valWeight";
            this.valWeight.Size = new System.Drawing.Size(100, 20);
            this.valWeight.TabIndex = 8;
            this.valWeight.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // valDrinks
            // 
            this.valDrinks.Location = new System.Drawing.Point(589, 75);
            this.valDrinks.Name = "valDrinks";
            this.valDrinks.Size = new System.Drawing.Size(100, 20);
            this.valDrinks.TabIndex = 9;
            // 
            // valHours
            // 
            this.valHours.Location = new System.Drawing.Point(589, 127);
            this.valHours.Name = "valHours";
            this.valHours.Size = new System.Drawing.Size(100, 20);
            this.valHours.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Number of Drinks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hours Since First Drink";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(589, 171);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 14;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            this.radMale.Click += new System.EventHandler(this.calc);
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(681, 171);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 15;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            this.radFemale.Click += new System.EventHandler(this.calc);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gender";
            // 
            // lblBAC
            // 
            this.lblBAC.AutoSize = true;
            this.lblBAC.Location = new System.Drawing.Point(592, 213);
            this.lblBAC.Name = "lblBAC";
            this.lblBAC.Size = new System.Drawing.Size(0, 13);
            this.lblBAC.TabIndex = 17;
            // 
            // lblAnalysis
            // 
            this.lblAnalysis.AutoSize = true;
            this.lblAnalysis.Location = new System.Drawing.Point(592, 230);
            this.lblAnalysis.Name = "lblAnalysis";
            this.lblAnalysis.Size = new System.Drawing.Size(0, 13);
            this.lblAnalysis.TabIndex = 18;
            // 
            // lblAnalysis2
            // 
            this.lblAnalysis2.AutoSize = true;
            this.lblAnalysis2.Location = new System.Drawing.Point(595, 258);
            this.lblAnalysis2.Name = "lblAnalysis2";
            this.lblAnalysis2.Size = new System.Drawing.Size(0, 13);
            this.lblAnalysis2.TabIndex = 19;
            // 
            // lblAnalysis3
            // 
            this.lblAnalysis3.AutoSize = true;
            this.lblAnalysis3.Location = new System.Drawing.Point(598, 288);
            this.lblAnalysis3.Name = "lblAnalysis3";
            this.lblAnalysis3.Size = new System.Drawing.Size(0, 13);
            this.lblAnalysis3.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(864, 579);
            this.Controls.Add(this.lblAnalysis3);
            this.Controls.Add(this.lblAnalysis2);
            this.Controls.Add(this.lblAnalysis);
            this.Controls.Add(this.lblBAC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valHours);
            this.Controls.Add(this.valDrinks);
            this.Controls.Add(this.valWeight);
            this.Controls.Add(this.toolStripStatusLabel);
            this.Controls.Add(this.FavoritesDrinkButton);
            this.Controls.Add(this.DrinkTextBox);
            this.Controls.Add(this.DrinkBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DrinkBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bartenderExpressDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
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
        private bartenderExpressDataSetTableAdapters.recipesTableAdapter recipesTableAdapter;
        private bartenderExpressDataSet bartenderExpressDataSet;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private System.Windows.Forms.TextBox valWeight;
        private System.Windows.Forms.TextBox valDrinks;
        private System.Windows.Forms.TextBox valHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBAC;
        private System.Windows.Forms.Label lblAnalysis;
        private System.Windows.Forms.Label lblAnalysis2;
        private System.Windows.Forms.Label lblAnalysis3;
    }
}