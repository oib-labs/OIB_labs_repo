﻿
namespace OIB_lab_2
{
    partial class Form4
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
            this.LblName4 = new System.Windows.Forms.Label();
            this.TbSurname4 = new System.Windows.Forms.TextBox();
            this.TbOtch4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(165, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать,";
            // 
            // LblName4
            // 
            this.LblName4.AutoSize = true;
            this.LblName4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblName4.Location = new System.Drawing.Point(257, 73);
            this.LblName4.Name = "LblName4";
            this.LblName4.Size = new System.Drawing.Size(131, 37);
            this.LblName4.TabIndex = 1;
            this.LblName4.Text = "<name>";
            // 
            // TbSurname4
            // 
            this.TbSurname4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbSurname4.Location = new System.Drawing.Point(147, 147);
            this.TbSurname4.Name = "TbSurname4";
            this.TbSurname4.Size = new System.Drawing.Size(362, 38);
            this.TbSurname4.TabIndex = 2;
            // 
            // TbOtch4
            // 
            this.TbOtch4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbOtch4.Location = new System.Drawing.Point(147, 224);
            this.TbOtch4.Name = "TbOtch4";
            this.TbOtch4.Size = new System.Drawing.Size(362, 38);
            this.TbOtch4.TabIndex = 3;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 579);
            this.Controls.Add(this.TbOtch4);
            this.Controls.Add(this.TbSurname4);
            this.Controls.Add(this.LblName4);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblName4;
        private System.Windows.Forms.TextBox TbSurname4;
        private System.Windows.Forms.TextBox TbOtch4;
    }
}