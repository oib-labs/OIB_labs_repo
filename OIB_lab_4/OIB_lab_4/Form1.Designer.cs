
namespace OIB_lab_4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbKSumm = new System.Windows.Forms.TextBox();
            this.TbGamming = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "a =31, b =7, c = MaxVal+1 =256, t0 =  126";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Метод контрольных сумм";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Метод гаммирования";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TbKSumm
            // 
            this.TbKSumm.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbKSumm.Location = new System.Drawing.Point(374, 51);
            this.TbKSumm.Name = "TbKSumm";
            this.TbKSumm.ReadOnly = true;
            this.TbKSumm.Size = new System.Drawing.Size(186, 34);
            this.TbKSumm.TabIndex = 3;
            this.TbKSumm.TextChanged += new System.EventHandler(this.TbControlSumm_TextChanged);
            // 
            // TbGamming
            // 
            this.TbGamming.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbGamming.Location = new System.Drawing.Point(374, 150);
            this.TbGamming.Name = "TbGamming";
            this.TbGamming.ReadOnly = true;
            this.TbGamming.Size = new System.Drawing.Size(186, 34);
            this.TbGamming.TabIndex = 4;
            this.TbGamming.TextChanged += new System.EventHandler(this.TbGamming_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TbGamming);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TbKSumm);
            this.panel1.Location = new System.Drawing.Point(64, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 280);
            this.panel1.TabIndex = 5;
            // 
            // TbInput
            // 
            this.TbInput.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbInput.Location = new System.Drawing.Point(64, 118);
            this.TbInput.Name = "TbInput";
            this.TbInput.Size = new System.Drawing.Size(572, 34);
            this.TbInput.TabIndex = 5;
            this.TbInput.TextChanged += new System.EventHandler(this.TbInput_TextChanged);
            this.TbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbInput_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(59, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Текст";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(280, 518);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(130, 47);
            this.BtnCalculate.TabIndex = 6;
            this.BtnCalculate.Text = "button1";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 587);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lab4 (10 var)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbKSumm;
        private System.Windows.Forms.TextBox TbGamming;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCalculate;
    }
}

