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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CabinetSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.listBoxControl2 = new DevExpress.XtraEditors.ListBoxControl();
            this.listBoxControl2_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteItemButton = new DevExpress.XtraEditors.SimpleButton();
            this.ClearItemButton = new DevExpress.XtraEditors.SimpleButton();
            this.CabinetSearchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).BeginInit();
            this.listBoxControl2_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Ingredients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your Ingredients";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(25, 66);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxControl1.Size = new System.Drawing.Size(252, 334);
            this.listBoxControl1.TabIndex = 6;
            this.listBoxControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxControl1_MouseDown);
            this.listBoxControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxControl1_MouseMove);
            // 
            // listBoxControl2
            // 
            this.listBoxControl2.AllowDrop = true;
            this.listBoxControl2.ContextMenuStrip = this.listBoxControl2_contextMenuStrip;
            this.listBoxControl2.Location = new System.Drawing.Point(298, 66);
            this.listBoxControl2.Name = "listBoxControl2";
            this.listBoxControl2.Size = new System.Drawing.Size(252, 334);
            this.listBoxControl2.TabIndex = 7;
            this.listBoxControl2.SelectedIndexChanged += new System.EventHandler(this.listBoxControl2_SelectedIndexChanged);
            this.listBoxControl2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxControl2_DragDrop);
            this.listBoxControl2.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxControl2_DragOver);
            // 
            // listBoxControl2_contextMenuStrip
            // 
            this.listBoxControl2_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.listBoxControl2_contextMenuStrip.Name = "contextMenuStrip1";
            this.listBoxControl2_contextMenuStrip.Size = new System.Drawing.Size(119, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem1.Text = "Remove";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem2.Text = "Clear All";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ClearItemButton_Click);
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.DeleteItemButton.Enabled = false;
            this.DeleteItemButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteItemButton.Image")));
            this.DeleteItemButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.DeleteItemButton.Location = new System.Drawing.Point(400, 12);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(75, 54);
            this.DeleteItemButton.TabIndex = 8;
            this.DeleteItemButton.Text = "Remove Item";
            this.DeleteItemButton.Visible = false;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // ClearItemButton
            // 
            this.ClearItemButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.ClearItemButton.Enabled = false;
            this.ClearItemButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearItemButton.Image")));
            this.ClearItemButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.ClearItemButton.Location = new System.Drawing.Point(475, 12);
            this.ClearItemButton.Name = "ClearItemButton";
            this.ClearItemButton.Size = new System.Drawing.Size(75, 54);
            this.ClearItemButton.TabIndex = 9;
            this.ClearItemButton.Text = "Clear All";
            this.ClearItemButton.Visible = false;
            this.ClearItemButton.Click += new System.EventHandler(this.ClearItemButton_Click);
            // 
            // CabinetSearchBox
            // 
            this.CabinetSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CabinetSearchBox.Location = new System.Drawing.Point(25, 40);
            this.CabinetSearchBox.MaximumSize = new System.Drawing.Size(252, 20);
            this.CabinetSearchBox.MinimumSize = new System.Drawing.Size(252, 20);
            this.CabinetSearchBox.Name = "CabinetSearchBox";
            this.CabinetSearchBox.Size = new System.Drawing.Size(252, 20);
            this.CabinetSearchBox.TabIndex = 10;
            this.CabinetSearchBox.TextChanged += new System.EventHandler(this.CabinetSearchBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Drag and Drop your Ingredients!";
            // 
            // CabinetSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 424);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CabinetSearchBox);
            this.Controls.Add(this.ClearItemButton);
            this.Controls.Add(this.DeleteItemButton);
            this.Controls.Add(this.listBoxControl2);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CabinetSearch";
            this.Text = "Liqueur Cabinet";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).EndInit();
            this.listBoxControl2_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private System.Windows.Forms.ContextMenuStrip listBoxControl2_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private DevExpress.XtraEditors.SimpleButton DeleteItemButton;
        private DevExpress.XtraEditors.SimpleButton ClearItemButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        public DevExpress.XtraEditors.ListBoxControl listBoxControl2;
        private System.Windows.Forms.TextBox CabinetSearchBox;
        private System.Windows.Forms.Label label3;
    }
}