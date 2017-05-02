namespace bartenderexpressReloaded
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
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
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
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bartenderExpressDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Amount});
            this.listView1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(-2, 0);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(225, 349);
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
            this.listView2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(220, 0);
            this.listView2.Name = "listView2";
            this.listView2.Scrollable = false;
            this.listView2.Size = new System.Drawing.Size(345, 349);
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
            this.richTextBox1.Location = new System.Drawing.Point(-2, 348);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(567, 208);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // DrinkBox
            // 
            this.DrinkBox.Location = new System.Drawing.Point(-2, 348);
            this.DrinkBox.Name = "DrinkBox";
            this.DrinkBox.Size = new System.Drawing.Size(224, 229);
            this.DrinkBox.TabIndex = 4;
            this.DrinkBox.TabStop = false;
            // 
            // DrinkTextBox
            // 
            this.DrinkTextBox.Location = new System.Drawing.Point(220, 348);
            this.DrinkTextBox.Multiline = true;
            this.DrinkTextBox.Name = "DrinkTextBox";
            this.DrinkTextBox.ReadOnly = true;
            this.DrinkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DrinkTextBox.Size = new System.Drawing.Size(345, 229);
            this.DrinkTextBox.TabIndex = 5;
            // 
            // FavoritesDrinkButton
            // 
            this.FavoritesDrinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FavoritesDrinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavoritesDrinkButton.ForeColor = System.Drawing.Color.Black;
            this.FavoritesDrinkButton.Image = ((System.Drawing.Image)(resources.GetObject("FavoritesDrinkButton.Image")));
            this.FavoritesDrinkButton.Location = new System.Drawing.Point(548, 0);
            this.FavoritesDrinkButton.Name = "FavoritesDrinkButton";
            this.FavoritesDrinkButton.Size = new System.Drawing.Size(16, 20);
            this.FavoritesDrinkButton.TabIndex = 6;
            this.FavoritesDrinkButton.Tag = "Add to Favorites";
            this.FavoritesDrinkButton.Text = "button1";
            this.FavoritesDrinkButton.UseVisualStyleBackColor = true;
            this.FavoritesDrinkButton.Click += new System.EventHandler(this.FavoritesDrinkButton_Click);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripStatusLabel.Location = new System.Drawing.Point(0, 560);
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(1098, 20);
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
            // tileItem5
            // 
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement2.Text = "tileItem5";
            this.tileItem5.Elements.Add(tileItemElement2);
            this.tileItem5.Id = 8;
            this.tileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem5.Name = "tileItem5";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Name = "tileGroup3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1098, 579);
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
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileItem tileItem5;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
    }
}