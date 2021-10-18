using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InSec2_v2
{
    
    public partial class Form2 : Form
    {
        int i = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void bt_reg_Click(object sender, EventArgs e)
        {
            if (txt_id.Text==""|| txt_pass.Text == "" || txt_surname.Text == "" || txt_name.Text == "" || txt_2_surname.Text == "" || txt_birthday.Text == "" || txt_place.Text == "" ||
                txt_phone.Text == "")// проверка на пустые поля
            {
                MessageBox.Show("Вы забыли ввести данные");
                return;
            }

            if (checkCorrectPass(txt_pass.Text) == false)
            {
                MessageBox.Show("Пароль не соответствует требованиям безопасности. Пожалуйста, уберите повторяющиеся символы.");
                return;
            }
            if (isUserExist()) return;
            

            Db db = new Db();
            // создаём команды
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `Surname`, `Name`, `2-surname`, `Birthday`, `Place of birthday.`, `phone`) VALUES (@login, @password, @surname, @name, @surname2, @birthday, @placeofbirth, @phone);", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = txt_id.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txt_pass.Text;
            command.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = txt_surname.Text;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = txt_name.Text;
            command.Parameters.Add("@surname2", MySqlDbType.VarChar).Value = txt_2_surname.Text;
            command.Parameters.Add("@birthday", MySqlDbType.VarChar).Value = txt_birthday.Text;
            command.Parameters.Add("@placeofbirth", MySqlDbType.VarChar).Value = txt_place.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = txt_phone.Text;

            //открываем соединение
            db.openConnection();

            if (command.ExecuteNonQuery() ==1)
            {
                MessageBox.Show("Аккаунт был создан");
            }

            // закрываем соединение
            db.closeConnection();

            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
            form3.lab_login.Text = txt_id.Text;
        }
        
        // Функция проверки на занятость логина
        public Boolean isUserExist()
                    {
                        Db db = new Db();
                        DataTable table = new DataTable();

                        MySqlDataAdapter adapter = new MySqlDataAdapter();

                        MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`= @uL", db.getConnection());
                        command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = txt_id.Text;
                        

                        adapter.SelectCommand = command;
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Логин уже занят");
                            return true;
                        }
                        else
                        {
                            
                            return false;
                        }
                    }

        private void bt_back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void bt_show_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txt_pass.UseSystemPasswordChar = false;
                i++;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
                i--;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_pass.TextLength - 1 <= 6)
            {
                if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
                {

                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        public Boolean checkCorrectPass(String pass)
        {
            pass = pass.ToLower();
            char last_char = pass[0];
            for (int i = 1; i < pass.Length; i++)
            {
                if (last_char == pass[i])
                {

                    return false;
                }
                last_char = pass[i];
            }
            return true;
        }
    }
}
