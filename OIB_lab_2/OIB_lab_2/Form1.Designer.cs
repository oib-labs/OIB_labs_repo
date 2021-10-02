
namespace OIB_lab_2
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TbID1 = new System.Windows.Forms.TextBox();
            this.TbPass1 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnChangePass1 = new System.Windows.Forms.Button();
            this.LblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLogin.Location = new System.Drawing.Point(105, 223);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(192, 47);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Войти";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TbID1
            // 
            this.TbID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbID1.Location = new System.Drawing.Point(115, 52);
            this.TbID1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbID1.Name = "TbID1";
            this.TbID1.Size = new System.Drawing.Size(165, 38);
            this.TbID1.TabIndex = 1;
            // 
            // TbPass1
            // 
            this.TbPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbPass1.Location = new System.Drawing.Point(116, 135);
            this.TbPass1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbPass1.Name = "TbPass1";
            this.TbPass1.Size = new System.Drawing.Size(165, 38);
            this.TbPass1.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(111, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(177, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Имя пользователя";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPass.Location = new System.Drawing.Point(111, 110);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(76, 23);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Пароль";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRegister.Location = new System.Drawing.Point(105, 329);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(192, 47);
            this.BtnRegister.TabIndex = 5;
            this.BtnRegister.Text = "Регистрация";
            this.BtnRegister.UseVisualStyleBackColor = true;
            // 
            // BtnChangePass1
            // 
            this.BtnChangePass1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnChangePass1.Location = new System.Drawing.Point(105, 275);
            this.BtnChangePass1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnChangePass1.Name = "BtnChangePass1";
            this.BtnChangePass1.Size = new System.Drawing.Size(192, 47);
            this.BtnChangePass1.TabIndex = 6;
            this.BtnChangePass1.Text = "Сменить пароль";
            this.BtnChangePass1.UseVisualStyleBackColor = true;
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(144, 186);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(101, 23);
            this.LblError.TabIndex = 7;
            this.LblError.Text = "*ошибка*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 412);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.BtnChangePass1);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.TbPass1);
            this.Controls.Add(this.TbID1);
            this.Controls.Add(this.BtnLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Вход(10 вариант)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TbID1;
        private System.Windows.Forms.TextBox TbPass1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnChangePass1;
        private System.Windows.Forms.Label LblError;
    }
}

