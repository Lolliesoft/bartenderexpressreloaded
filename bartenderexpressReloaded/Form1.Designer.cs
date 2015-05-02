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
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource();
            this.bartenderExpressDataSet = new bartenderexpressReloaded.bartenderExpressDataSet();
            this.recipesTableAdapter = new bartenderexpressReloaded.bartenderExpressDataSetTableAdapters.recipesTableAdapter();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bartenderExpressDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.DataSource = this.recipesBindingSource;
            this.listBoxControl1.DisplayMember = "name";
            this.listBoxControl1.Location = new System.Drawing.Point(1, 1);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(227, 429);
            this.listBoxControl1.TabIndex = 1;
            this.listBoxControl1.ValueMember = "name";
            this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
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
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 485);
            this.Controls.Add(this.listBoxControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bartenderExpressDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private bartenderExpressDataSet bartenderExpressDataSet;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private bartenderExpressDataSetTableAdapters.recipesTableAdapter recipesTableAdapter;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

