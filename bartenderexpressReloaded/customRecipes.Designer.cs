namespace bartenderexpressReloaded
{
    partial class customRecipes
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
            this.DrinkNameLabel = new System.Windows.Forms.Label();
            this.amt1Label = new System.Windows.Forms.Label();
            this.txtDrinkName = new System.Windows.Forms.TextBox();
            this.txtAmt1 = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Ingredient1Label = new System.Windows.Forms.Label();
            this.as42 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DrinkNameLabel
            // 
            this.DrinkNameLabel.AutoSize = true;
            this.DrinkNameLabel.Location = new System.Drawing.Point(13, 13);
            this.DrinkNameLabel.Name = "DrinkNameLabel";
            this.DrinkNameLabel.Size = new System.Drawing.Size(60, 13);
            this.DrinkNameLabel.TabIndex = 0;
            this.DrinkNameLabel.Text = "DrinkName";
            // 
            // amt1Label
            // 
            this.amt1Label.AutoSize = true;
            this.amt1Label.Location = new System.Drawing.Point(13, 41);
            this.amt1Label.Name = "amt1Label";
            this.amt1Label.Size = new System.Drawing.Size(55, 13);
            this.amt1Label.TabIndex = 1;
            this.amt1Label.Text = "Amount 1:";
            // 
            // txtDrinkName
            // 
            this.txtDrinkName.Location = new System.Drawing.Point(90, 10);
            this.txtDrinkName.Name = "txtDrinkName";
            this.txtDrinkName.Size = new System.Drawing.Size(431, 20);
            this.txtDrinkName.TabIndex = 2;
            // 
            // txtAmt1
            // 
            this.txtAmt1.Location = new System.Drawing.Point(90, 38);
            this.txtAmt1.Name = "txtAmt1";
            this.txtAmt1.Size = new System.Drawing.Size(134, 20);
            this.txtAmt1.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(490, 443);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Ingredient1Label
            // 
            this.Ingredient1Label.AutoSize = true;
            this.Ingredient1Label.Location = new System.Drawing.Point(255, 41);
            this.Ingredient1Label.Name = "Ingredient1Label";
            this.Ingredient1Label.Size = new System.Drawing.Size(66, 13);
            this.Ingredient1Label.TabIndex = 5;
            this.Ingredient1Label.Text = "Ingredient 1:";
            // 
            // as42
            // 
            this.as42.Location = new System.Drawing.Point(328, 41);
            this.as42.Name = "as42";
            this.as42.Size = new System.Drawing.Size(100, 20);
            this.as42.TabIndex = 6;
            // 
            // customRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 511);
            this.Controls.Add(this.as42);
            this.Controls.Add(this.Ingredient1Label);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.txtAmt1);
            this.Controls.Add(this.txtDrinkName);
            this.Controls.Add(this.amt1Label);
            this.Controls.Add(this.DrinkNameLabel);
            this.Name = "customRecipes";
            this.Text = "customRecipes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DrinkNameLabel;
        private System.Windows.Forms.Label amt1Label;
        private System.Windows.Forms.TextBox txtDrinkName;
        private System.Windows.Forms.TextBox txtAmt1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label Ingredient1Label;
        private System.Windows.Forms.TextBox as42;
    }
}