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
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame5 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement13 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame6 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement14 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement15 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame7 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement16 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemFrame tileItemFrame8 = new DevExpress.XtraEditors.TileItemFrame();
            DevExpress.XtraEditors.TileItemElement tileItemElement17 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement18 = new DevExpress.XtraEditors.TileItemElement();
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
            this.recipesBindingSource = new System.Windows.Forms.BindingSource();
            this.recipesTableAdapter = new bartenderexpressReloaded.bartenderExpressDataSetTableAdapters.recipesTableAdapter();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.Form2Group = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bartenderExpressDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Amount});
            this.listView1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(-3, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(299, 429);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 294;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ingredients});
            this.listView2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(293, 0);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Scrollable = false;
            this.listView2.Size = new System.Drawing.Size(459, 429);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // Ingredients
            // 
            this.Ingredients.Text = "Ingredients";
            this.Ingredients.Width = 455;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-3, 428);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(755, 255);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // DrinkBox
            // 
            this.DrinkBox.Location = new System.Drawing.Point(-3, 428);
            this.DrinkBox.Margin = new System.Windows.Forms.Padding(4);
            this.DrinkBox.Name = "DrinkBox";
            this.DrinkBox.Size = new System.Drawing.Size(299, 282);
            this.DrinkBox.TabIndex = 4;
            this.DrinkBox.TabStop = false;
            // 
            // DrinkTextBox
            // 
            this.DrinkTextBox.Location = new System.Drawing.Point(293, 428);
            this.DrinkTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DrinkTextBox.Multiline = true;
            this.DrinkTextBox.Name = "DrinkTextBox";
            this.DrinkTextBox.ReadOnly = true;
            this.DrinkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DrinkTextBox.Size = new System.Drawing.Size(459, 281);
            this.DrinkTextBox.TabIndex = 5;
            // 
            // FavoritesDrinkButton
            // 
            this.FavoritesDrinkButton.ForeColor = System.Drawing.Color.Black;
            this.FavoritesDrinkButton.Image = ((System.Drawing.Image)(resources.GetObject("FavoritesDrinkButton.Image")));
            this.FavoritesDrinkButton.Location = new System.Drawing.Point(714, 1);
            this.FavoritesDrinkButton.Margin = new System.Windows.Forms.Padding(4);
            this.FavoritesDrinkButton.Name = "FavoritesDrinkButton";
            this.FavoritesDrinkButton.Size = new System.Drawing.Size(29, 27);
            this.FavoritesDrinkButton.TabIndex = 6;
            this.FavoritesDrinkButton.Tag = "Add to Favorites";
            this.FavoritesDrinkButton.Text = "button1";
            this.FavoritesDrinkButton.UseVisualStyleBackColor = true;
            this.FavoritesDrinkButton.Click += new System.EventHandler(this.FavoritesDrinkButton_Click);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripStatusLabel.Location = new System.Drawing.Point(0, 686);
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.toolStripStatusLabel.Size = new System.Drawing.Size(1464, 27);
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
            // tileGroup1
            // 
            this.tileGroup1.Name = "tileGroup1";
            // 
            // tileControl1
            // 
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Groups.Add(this.Form2Group);
            this.tileControl1.ItemSize = 160;
            this.tileControl1.Location = new System.Drawing.Point(789, 0);
            this.tileControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tileControl1.MaxId = 21;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Padding = new System.Windows.Forms.Padding(24, 22, 24, 22);
            this.tileControl1.Size = new System.Drawing.Size(372, 710);
            this.tileControl1.TabIndex = 8;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileItem5
            // 
            tileItemElement10.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement10.Image")));
            tileItemElement10.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement10.Text = "tileItem5";
            this.tileItem5.Elements.Add(tileItemElement10);
            this.tileItem5.Id = 8;
            this.tileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem5.Name = "tileItem5";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Name = "tileGroup3";
            // 
            // Form2Group
            // 
            this.Form2Group.Items.Add(this.tileItem1);
            this.Form2Group.Items.Add(this.tileItem2);
            this.Form2Group.Items.Add(this.tileItem3);
            this.Form2Group.Items.Add(this.tileItem4);
            this.Form2Group.Name = "Form2Group";
            this.Form2Group.Text = "Form2 Group";
            // 
            // tileItem1
            // 
            this.tileItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItem1.BackgroundImage")));
            this.tileItem1.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileItemElement11.Text = "<size=+5>Liquor Cabinet</size>";
            tileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tileItem1.Elements.Add(tileItemElement11);
            this.tileItem1.Id = 17;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.tileItem1.Name = "tileItem1";
            // 
            // tileItem2
            // 
            this.tileItem2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItem2.BackgroundImage")));
            this.tileItem2.CurrentFrameIndex = 1;
            tileItemElement12.Text = "Measurement Calculator";
            this.tileItem2.Elements.Add(tileItemElement12);
            this.tileItem2.FrameAnimationInterval = 4500;
            tileItemFrame5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemFrame5.BackgroundImage")));
            tileItemElement13.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement13.Image")));
            tileItemElement13.Text = "";
            tileItemFrame5.Elements.Add(tileItemElement13);
            tileItemFrame5.Image = ((System.Drawing.Image)(resources.GetObject("tileItemFrame5.Image")));
            tileItemFrame6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemFrame6.BackgroundImage")));
            tileItemElement14.Text = "Measurement Calculator";
            tileItemFrame6.Elements.Add(tileItemElement14);
            this.tileItem2.Frames.Add(tileItemFrame5);
            this.tileItem2.Frames.Add(tileItemFrame6);
            this.tileItem2.Id = 18;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem2.Name = "tileItem2";
            // 
            // tileItem3
            // 
            this.tileItem3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItem3.BackgroundImage")));
            tileItemElement15.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement15.Image")));
            tileItemElement15.Text = "";
            this.tileItem3.Elements.Add(tileItemElement15);
            this.tileItem3.FrameAnimationInterval = 4800;
            tileItemFrame7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemFrame7.BackgroundImage")));
            tileItemElement16.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement16.Image")));
            tileItemElement16.Text = "";
            tileItemFrame7.Elements.Add(tileItemElement16);
            tileItemFrame7.Image = ((System.Drawing.Image)(resources.GetObject("tileItemFrame7.Image")));
            tileItemFrame8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemFrame8.BackgroundImage")));
            tileItemElement17.Text = "Favorites";
            tileItemElement17.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            tileItemFrame8.Elements.Add(tileItemElement17);
            this.tileItem3.Frames.Add(tileItemFrame7);
            this.tileItem3.Frames.Add(tileItemFrame8);
            this.tileItem3.Id = 19;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem3.Name = "tileItem3";
            // 
            // tileItem4
            // 
            this.tileItem4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItem4.BackgroundImage")));
            tileItemElement18.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement18.Image")));
            tileItemElement18.Text = "<size=+4>Random Drink</size>";
            tileItemElement18.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.tileItem4.Elements.Add(tileItemElement18);
            this.tileItem4.Id = 20;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem4.Name = "tileItem4";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1464, 713);
            this.Controls.Add(this.tileControl1);
            this.Controls.Add(this.toolStripStatusLabel);
            this.Controls.Add(this.FavoritesDrinkButton);
            this.Controls.Add(this.DrinkTextBox);
            this.Controls.Add(this.DrinkBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileItem tileItem5;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileGroup Form2Group;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem4;
    }
}