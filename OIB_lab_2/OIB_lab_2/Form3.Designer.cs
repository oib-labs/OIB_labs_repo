
namespace OIB_lab_2
{
    partial class Form3
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
            this.TbCurPass3 = new System.Windows.Forms.TextBox();
            this.TbNewPass3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNewPassRep3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSave3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текущий пароль";
            // 
            // TbCurPass3
            // 
            this.TbCurPass3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbCurPass3.Location = new System.Drawing.Point(403, 57);
            this.TbCurPass3.Name = "TbCurPass3";
            this.TbCurPass3.Size = new System.Drawing.Size(233, 35);
            this.TbCurPass3.TabIndex = 2;
            // 
            // TbNewPass3
            // 
            this.TbNewPass3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbNewPass3.Location = new System.Drawing.Point(403, 177);
            this.TbNewPass3.Name = "TbNewPass3";
            this.TbNewPass3.Size = new System.Drawing.Size(233, 35);
            this.TbNewPass3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Новый пароль";
            // 
            // TbNewPassRep3
            // 
            this.TbNewPassRep3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbNewPassRep3.Location = new System.Drawing.Point(403, 288);
            this.TbNewPassRep3.Name = "TbNewPassRep3";
            this.TbNewPassRep3.Size = new System.Drawing.Size(233, 35);
            this.TbNewPassRep3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Новый пароль (повторить)";
            // 
            // BtnSave3
            // 
            this.BtnSave3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSave3.Location = new System.Drawing.Point(40, 381);
            this.BtnSave3.Name = "BtnSave3";
            this.BtnSave3.Size = new System.Drawing.Size(596, 64);
            this.BtnSave3.TabIndex = 7;
            this.BtnSave3.Text = "Сохранить";
            this.BtnSave3.UseVisualStyleBackColor = true;
            this.BtnSave3.Click += new System.EventHandler(this.BtnSave3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 496);
            this.Controls.Add(this.BtnSave3);
            this.Controls.Add(this.TbNewPassRep3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbNewPass3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbCurPass3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Смена пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbCurPass3;
        private System.Windows.Forms.TextBox TbNewPass3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNewPassRep3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSave3;
    }
}