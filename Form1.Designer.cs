﻿
namespace HF_15_Delegates2
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
            this.useIngredient = new System.Windows.Forms.Button();
            this.getSuzanne = new System.Windows.Forms.Button();
            this.getAmy = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // useIngredient
            // 
            this.useIngredient.Location = new System.Drawing.Point(13, 13);
            this.useIngredient.Name = "useIngredient";
            this.useIngredient.Size = new System.Drawing.Size(150, 31);
            this.useIngredient.TabIndex = 0;
            this.useIngredient.Text = "Pobierz składnik";
            this.useIngredient.UseVisualStyleBackColor = true;
            this.useIngredient.Click += new System.EventHandler(this.useIngredient_Click);
            // 
            // getSuzanne
            // 
            this.getSuzanne.Location = new System.Drawing.Point(12, 50);
            this.getSuzanne.Name = "getSuzanne";
            this.getSuzanne.Size = new System.Drawing.Size(210, 32);
            this.getSuzanne.TabIndex = 1;
            this.getSuzanne.Text = "Użyj delegatu Suzanne";
            this.getSuzanne.UseVisualStyleBackColor = true;
            this.getSuzanne.Click += new System.EventHandler(this.getSuzanne_Click);
            // 
            // getAmy
            // 
            this.getAmy.Location = new System.Drawing.Point(12, 88);
            this.getAmy.Name = "getAmy";
            this.getAmy.Size = new System.Drawing.Size(210, 33);
            this.getAmy.TabIndex = 2;
            this.getAmy.Text = "Użyj delegatu Amy";
            this.getAmy.UseVisualStyleBackColor = true;
            this.getAmy.Click += new System.EventHandler(this.getAmy_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(169, 18);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(54, 22);
            this.amount.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 133);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.getAmy);
            this.Controls.Add(this.getSuzanne);
            this.Controls.Add(this.useIngredient);
            this.Name = "Form1";
            this.Text = "Tajne składniki";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button useIngredient;
        private System.Windows.Forms.Button getSuzanne;
        private System.Windows.Forms.Button getAmy;
        private System.Windows.Forms.NumericUpDown amount;
    }
}

