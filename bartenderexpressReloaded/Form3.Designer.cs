namespace bartenderexpressReloaded
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.Ingredients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FavoritesButton = new System.Windows.Forms.Button();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Amount});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(299, 429);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 290;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ingredients});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(293, 0);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Scrollable = false;
            this.listView2.Size = new System.Drawing.Size(459, 429);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // Ingredients
            // 
            this.Ingredients.Text = "Ingredients";
            this.Ingredients.Width = 456;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-3, 428);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(755, 255);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // FavoritesButton
            // 
            this.FavoritesButton.ForeColor = System.Drawing.Color.Black;
            this.FavoritesButton.Image = ((System.Drawing.Image)(resources.GetObject("FavoritesButton.Image")));
            this.FavoritesButton.Location = new System.Drawing.Point(714, 1);
            this.FavoritesButton.Margin = new System.Windows.Forms.Padding(4);
            this.FavoritesButton.Name = "FavoritesButton";
            this.FavoritesButton.Size = new System.Drawing.Size(29, 27);
            this.FavoritesButton.TabIndex = 7;
            this.FavoritesButton.Tag = "Add to Favorites";
            this.FavoritesButton.Text = "FavoritesButton";
            this.FavoritesButton.UseVisualStyleBackColor = true;
            this.FavoritesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tileControl1
            // 
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Location = new System.Drawing.Point(789, 0);
            this.tileControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tileControl1.MaxId = 16;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Padding = new System.Windows.Forms.Padding(24, 22, 24, 22);
            this.tileControl1.Size = new System.Drawing.Size(372, 710);
            this.tileControl1.TabIndex = 9;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Items.Add(this.tileItem3);
            this.tileGroup2.Items.Add(this.tileItem2);
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = "tileGroup2";
            // 
            // tileItem1
            // 
            this.tileItem1.AppearanceItem.Hovered.BackColor = System.Drawing.Color.Transparent;
            this.tileItem1.AppearanceItem.Hovered.BackColor2 = System.Drawing.Color.Transparent;
            this.tileItem1.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.Transparent;
            this.tileItem1.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Hovered.Options.UseBorderColor = true;
            this.tileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileItem1.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.tileItem1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.RoyalBlue;
            this.tileItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem1.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Transparent;
            this.tileItem1.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.Transparent;
            this.tileItem1.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.Transparent;
            this.tileItem1.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileItem1.AppearanceItem.Selected.BackColor = System.Drawing.Color.Transparent;
            this.tileItem1.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Transparent;
            this.tileItem1.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Transparent;
            this.tileItem1.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileItem1.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.Fade;
            tileItemElement1.Appearance.Hovered.BackColor = System.Drawing.Color.Transparent;
            tileItemElement1.Appearance.Hovered.BackColor2 = System.Drawing.Color.Transparent;
            tileItemElement1.Appearance.Hovered.BorderColor = System.Drawing.Color.Transparent;
            tileItemElement1.Appearance.Hovered.Options.UseBackColor = true;
            tileItemElement1.Appearance.Hovered.Options.UseBorderColor = true;
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.Text = "";
            this.tileItem1.Elements.Add(tileItemElement1);
            this.tileItem1.Id = 11;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tileItem3
            // 
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.Text = "";
            this.tileItem3.Elements.Add(tileItemElement2);
            this.tileItem3.Id = 15;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.tileItem3.Name = "tileItem3";
            // 
            // tileItem2
            // 
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.Text = "";
            this.tileItem2.Elements.Add(tileItemElement3);
            this.tileItem2.Id = 12;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem2.Name = "tileItem2";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 713);
            this.Controls.Add(this.tileControl1);
            this.Controls.Add(this.FavoritesButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem2;
    }
}