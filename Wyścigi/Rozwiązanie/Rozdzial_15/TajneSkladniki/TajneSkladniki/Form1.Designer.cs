namespace TajneSkladniki
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
            this.getSuzanne = new System.Windows.Forms.Button();
            this.getAmy = new System.Windows.Forms.Button();
            this.useIngredient = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // getSuzanne
            // 
            this.getSuzanne.Location = new System.Drawing.Point(11, 31);
            this.getSuzanne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getSuzanne.Name = "getSuzanne";
            this.getSuzanne.Size = new System.Drawing.Size(144, 22);
            this.getSuzanne.TabIndex = 0;
            this.getSuzanne.Text = "Użyj deletatu Suzanne";
            this.getSuzanne.UseVisualStyleBackColor = true;
            this.getSuzanne.Click += new System.EventHandler(this.getSuzanne_Click);
            // 
            // getAmy
            // 
            this.getAmy.Location = new System.Drawing.Point(11, 56);
            this.getAmy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getAmy.Name = "getAmy";
            this.getAmy.Size = new System.Drawing.Size(144, 22);
            this.getAmy.TabIndex = 1;
            this.getAmy.Text = "Użyj delegatu Amy";
            this.getAmy.UseVisualStyleBackColor = true;
            this.getAmy.Click += new System.EventHandler(this.getAmy_Click);
            // 
            // useIngredient
            // 
            this.useIngredient.Location = new System.Drawing.Point(11, 6);
            this.useIngredient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.useIngredient.Name = "useIngredient";
            this.useIngredient.Size = new System.Drawing.Size(110, 22);
            this.useIngredient.TabIndex = 2;
            this.useIngredient.Text = "Pobierz składnik";
            this.useIngredient.UseVisualStyleBackColor = true;
            this.useIngredient.Click += new System.EventHandler(this.useIngredient_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(124, 6);
            this.amount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(30, 20);
            this.amount.TabIndex = 3;
            this.amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 92);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.useIngredient);
            this.Controls.Add(this.getAmy);
            this.Controls.Add(this.getSuzanne);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tajne składniki";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getSuzanne;
        private System.Windows.Forms.Button getAmy;
        private System.Windows.Forms.Button useIngredient;
        private System.Windows.Forms.NumericUpDown amount;
    }
}

