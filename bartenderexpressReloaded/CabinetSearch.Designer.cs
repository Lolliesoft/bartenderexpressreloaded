namespace bartenderexpressReloaded
{
    partial class CabinetSearch
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
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.listBoxControl2 = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Ingredients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your Ingredients";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(25, 45);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxControl1.Size = new System.Drawing.Size(252, 355);
            this.listBoxControl1.TabIndex = 6;
            this.listBoxControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxControl1_MouseDown);
            this.listBoxControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxControl1_MouseMove);
            // 
            // listBoxControl2
            // 
            this.listBoxControl2.AllowDrop = true;
            this.listBoxControl2.Location = new System.Drawing.Point(298, 45);
            this.listBoxControl2.Name = "listBoxControl2";
            this.listBoxControl2.Size = new System.Drawing.Size(252, 355);
            this.listBoxControl2.TabIndex = 7;
            this.listBoxControl2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxControl2_DragDrop);
            this.listBoxControl2.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxControl2_DragOver);
            // 
            // CabinetSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 424);
            this.Controls.Add(this.listBoxControl2);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CabinetSearch";
            this.Text = "Liqueur Cabinet";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl2;
    }
}