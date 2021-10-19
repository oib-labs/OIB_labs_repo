
namespace InSec2_v2
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
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.bt_reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Пароль";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(47, 101);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(200, 20);
            this.txt_login.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(47, 156);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(200, 20);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(88, 182);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(106, 23);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Войти";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // bt_reg
            // 
            this.bt_reg.Location = new System.Drawing.Point(88, 211);
            this.bt_reg.Name = "bt_reg";
            this.bt_reg.Size = new System.Drawing.Size(106, 23);
            this.bt_reg.TabIndex = 3;
            this.bt_reg.Text = "Регистрация";
            this.bt_reg.UseVisualStyleBackColor = true;
            this.bt_reg.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bt_reg);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Вход в ресурс";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button bt_reg;
    }
}

