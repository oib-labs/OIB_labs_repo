
namespace InSec2_v2
{
    partial class Form2
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_birthday = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_reg = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_2_surname = new System.Windows.Forms.TextBox();
            this.txt_place = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.bt_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(156, 45);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(151, 20);
            this.txt_id.TabIndex = 3;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(156, 71);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(151, 20);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.UseSystemPasswordChar = true;
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(156, 135);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(151, 20);
            this.txt_surname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Отчество:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(156, 161);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(151, 20);
            this.txt_name.TabIndex = 3;
            // 
            // txt_birthday
            // 
            this.txt_birthday.Location = new System.Drawing.Point(156, 263);
            this.txt_birthday.Name = "txt_birthday";
            this.txt_birthday.Size = new System.Drawing.Size(151, 20);
            this.txt_birthday.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дата рождения:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Место рождения:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Телефон:";
            // 
            // bt_reg
            // 
            this.bt_reg.Location = new System.Drawing.Point(50, 365);
            this.bt_reg.Name = "bt_reg";
            this.bt_reg.Size = new System.Drawing.Size(220, 39);
            this.bt_reg.TabIndex = 12;
            this.bt_reg.Text = "Зарегестрироваться";
            this.bt_reg.UseVisualStyleBackColor = true;
            this.bt_reg.Click += new System.EventHandler(this.bt_reg_Click);
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(223, 422);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(84, 34);
            this.bt_back.TabIndex = 18;
            this.bt_back.Text = "Назад";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(22, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Регистрация";
            // 
            // txt_2_surname
            // 
            this.txt_2_surname.Location = new System.Drawing.Point(156, 188);
            this.txt_2_surname.Name = "txt_2_surname";
            this.txt_2_surname.Size = new System.Drawing.Size(151, 20);
            this.txt_2_surname.TabIndex = 3;
            // 
            // txt_place
            // 
            this.txt_place.Location = new System.Drawing.Point(156, 289);
            this.txt_place.Name = "txt_place";
            this.txt_place.Size = new System.Drawing.Size(151, 20);
            this.txt_place.TabIndex = 3;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(156, 316);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(151, 20);
            this.txt_phone.TabIndex = 3;
            // 
            // bt_show
            // 
            this.bt_show.Location = new System.Drawing.Point(76, 68);
            this.bt_show.Name = "bt_show";
            this.bt_show.Size = new System.Drawing.Size(74, 23);
            this.bt_show.TabIndex = 20;
            this.bt_show.Text = "Показать";
            this.bt_show.UseVisualStyleBackColor = true;
            this.bt_show.Click += new System.EventHandler(this.bt_show_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 468);
            this.Controls.Add(this.bt_show);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_reg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_place);
            this.Controls.Add(this.txt_2_surname);
            this.Controls.Add(this.txt_birthday);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_birthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_reg;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_2_surname;
        private System.Windows.Forms.TextBox txt_place;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button bt_show;
    }
}