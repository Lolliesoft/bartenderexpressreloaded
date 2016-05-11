namespace bartenderexpressReloaded
{
    partial class BAC_Calculator
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
            this.lblAnalysis3 = new System.Windows.Forms.Label();
            this.lblAnalysis2 = new System.Windows.Forms.Label();
            this.lblAnalysis = new System.Windows.Forms.Label();
            this.lblBAC = new System.Windows.Forms.Label();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.valHours = new System.Windows.Forms.TextBox();
            this.valDrinks = new System.Windows.Forms.TextBox();
            this.valWeight = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Blood Alcohol Content Calculator";
            // 
            // lblAnalysis3
            // 
            this.lblAnalysis3.AutoSize = true;
            this.lblAnalysis3.Location = new System.Drawing.Point(33, 337);
            this.lblAnalysis3.Name = "lblAnalysis3";
            this.lblAnalysis3.Size = new System.Drawing.Size(13, 13);
            this.lblAnalysis3.TabIndex = 30;
            this.lblAnalysis3.Text = "3";
            // 
            // lblAnalysis2
            // 
            this.lblAnalysis2.AutoSize = true;
            this.lblAnalysis2.Location = new System.Drawing.Point(33, 306);
            this.lblAnalysis2.Name = "lblAnalysis2";
            this.lblAnalysis2.Size = new System.Drawing.Size(13, 13);
            this.lblAnalysis2.TabIndex = 29;
            this.lblAnalysis2.Text = "2";
            this.lblAnalysis2.Click += new System.EventHandler(this.lblAnalysis2_Click);
            // 
            // lblAnalysis
            // 
            this.lblAnalysis.AutoSize = true;
            this.lblAnalysis.Location = new System.Drawing.Point(33, 275);
            this.lblAnalysis.Name = "lblAnalysis";
            this.lblAnalysis.Size = new System.Drawing.Size(13, 13);
            this.lblAnalysis.TabIndex = 28;
            this.lblAnalysis.Text = "1";
            // 
            // lblBAC
            // 
            this.lblBAC.AutoSize = true;
            this.lblBAC.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBAC.Location = new System.Drawing.Point(381, 99);
            this.lblBAC.Name = "lblBAC";
            this.lblBAC.Size = new System.Drawing.Size(35, 37);
            this.lblBAC.TabIndex = 27;
            this.lblBAC.Text = "1";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(148, 183);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 26;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(50, 183);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 25;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // valHours
            // 
            this.valHours.BackColor = System.Drawing.SystemColors.Menu;
            this.valHours.Location = new System.Drawing.Point(38, 145);
            this.valHours.Name = "valHours";
            this.valHours.Size = new System.Drawing.Size(278, 20);
            this.valHours.TabIndex = 24;
            // 
            // valDrinks
            // 
            this.valDrinks.BackColor = System.Drawing.SystemColors.Menu;
            this.valDrinks.Location = new System.Drawing.Point(38, 108);
            this.valDrinks.Name = "valDrinks";
            this.valDrinks.Size = new System.Drawing.Size(278, 20);
            this.valDrinks.TabIndex = 23;
            // 
            // valWeight
            // 
            this.valWeight.BackColor = System.Drawing.SystemColors.Menu;
            this.valWeight.Location = new System.Drawing.Point(38, 72);
            this.valWeight.Name = "valWeight";
            this.valWeight.Size = new System.Drawing.Size(278, 20);
            this.valWeight.TabIndex = 22;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(38, 222);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 32;
            this.simpleButton1.Text = "Calculate";
            this.simpleButton1.Click += new System.EventHandler(this.calc);
            // 
            // BAC_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 417);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAnalysis3);
            this.Controls.Add(this.lblAnalysis2);
            this.Controls.Add(this.lblAnalysis);
            this.Controls.Add(this.lblBAC);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.valHours);
            this.Controls.Add(this.valDrinks);
            this.Controls.Add(this.valWeight);
            this.Name = "BAC_Calculator";
            this.Text = "Blood Alcoholic Content Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnalysis3;
        private System.Windows.Forms.Label lblAnalysis2;
        private System.Windows.Forms.Label lblAnalysis;
        private System.Windows.Forms.Label lblBAC;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox valHours;
        private System.Windows.Forms.TextBox valDrinks;
        private System.Windows.Forms.TextBox valWeight;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}