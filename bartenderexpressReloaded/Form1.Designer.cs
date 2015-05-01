namespace bartenderexpressReloaded
{
    partial class Form1
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bartenderExpressDataSet = new bartenderexpressReloaded.bartenderExpressDataSet();
            this.recipesTableAdapter = new bartenderexpressReloaded.bartenderExpressDataSetTableAdapters.recipesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bartenderExpressDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(279, 54);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(659, 435);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(653, 407);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(653, 407);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.DataSource = this.recipesBindingSource;
            this.listBoxControl1.DisplayMember = "name";
            this.listBoxControl1.Location = new System.Drawing.Point(12, 54);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(227, 429);
            this.listBoxControl1.TabIndex = 1;
            this.listBoxControl1.ValueMember = "name";
            this.listBoxControl1.DoubleClick += new System.EventHandler(this.nameListCount);
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "recipes";
            this.recipesBindingSource.DataSource = this.bartenderExpressDataSet;
            // 
            // bartenderExpressDataSet
            // 
            this.bartenderExpressDataSet.DataSetName = "bartenderExpressDataSet";
            this.bartenderExpressDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 485);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.xtraTabControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bartenderExpressDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private bartenderExpressDataSet bartenderExpressDataSet;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private bartenderExpressDataSetTableAdapters.recipesTableAdapter recipesTableAdapter;
    }
}

