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
    public partial class Form3 : Form
    {
        int flag1 = 0;
        int flag2 = 0;
        //String login = "";
        
        public Form3()
        {
            InitializeComponent();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
            

        }

        private void bt_show1_Click(object sender, EventArgs e)
        {
            if (flag1 == 0)
            {
                txt_newpass.UseSystemPasswordChar = false;
                flag1++;
            }
            else
            {
                txt_newpass.UseSystemPasswordChar = true;
                flag1--;
            }
        }
        

        private void bt_show2_Click_1(object sender, EventArgs e)
        {
            if (flag2 == 0)
                        {
                            txt_newpass2.UseSystemPasswordChar = false;
                            flag2++;
                        }
                        else
                        {
                            txt_newpass2.UseSystemPasswordChar = true;
                            flag2--;
                        }
        }

        private void button1_Click(object sender, EventArgs e)// кнопка сменить пароль
        {
            if ((txt_newpass.Text != txt_newpass2.Text) || txt_newpass.Text==""||txt_newpass2.Text=="")
            {
                MessageBox.Show("Пароли не совпадают. Проверьте правильность введённых данных.");
                return;
            }
            String pass = txt_newpass.Text;
            if (checkCorrectPass(pass) == false)
            {
                MessageBox.Show("Пароль не соответствует требованиям. Исключите повторяющиеся символы.");
                return;
            }
            else
            {
                //MessageBox.Show("Пароль соответствует требованиям.");

                Db db = new Db();
                // создаём команды
                MySqlCommand command = new MySqlCommand("UPDATE `users` SET `password` = @pass WHERE `users`.`login` = @login;", db.getConnection());
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = lab_login.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txt_newpass.Text;

                //открываем соединение
                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Пароль успешно заменён");
                    txt_newpass.Text = "";
                    txt_newpass2.Text = "";
                }

                // закрываем соединение
                db.closeConnection();
                
            }


        }
        public Boolean checkCorrectPass(String pass)
        {
            pass = pass.ToLower();
            char last_char = pass[0];
            for(int i = 1; i < pass.Length; i++)
            {
                if (last_char == pass[i])
                {
                    
                    return false;
                }
                last_char = pass[i];
            }
            return true;
        }

        private void txt_newpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (txt_newpass.TextLength-1<=6  )
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

        private void txt_newpass2_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (txt_newpass2.TextLength - 1 <= 6)
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

        private void bt_rub_in_dol_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_rub.Text != "")
                {
                    int sum = int.Parse(txt_rub.Text);
                    double res = sum / double.Parse(txt_kurs.Text);
                    res = Math.Round(res, 2);
                    txt_out1.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("Вы забыли ввести данные.");
                }
            }
            catch
            {
                MessageBox.Show("Слишком большое число.");
            }
        }

        private void bt_dol_in_rub_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_dol.Text != "")
                {
                    int sum = int.Parse(txt_dol.Text);
                    double res = sum * double.Parse(txt_kurs.Text);
                    res = Math.Round(res, 2);
                    txt_out2.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("Вы забыли ввести данные.");
                }
            }
            catch
            {
                MessageBox.Show("Слишком большое число.");
            }
        }

        private void bt_solve_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_P.Text != "" || txt_k.Text != "" || txt_n.Text != "")
                {
                    double p = int.Parse(txt_P.Text);// сумма вклада
                    double i = int.Parse(txt_k.Text);
                    int n = int.Parse(txt_n.Text);
                    double s = p * Math.Pow((1 + (i * 30) / (100 * 365)), n);
                    s = Math.Round(s, 2);
                    double stonks = s - p;
                    txt_out3.Text = s.ToString();
                    stonks = Math.Round(stonks, 2);
                    txt_stonks.Text = stonks.ToString();
                }
                else
                {
                    MessageBox.Show("Вы забыли ввести данные.");
                }
            }
            catch
            {
                MessageBox.Show("Слишком большое число.");
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txt_rub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar==48 && txt_rub.Text == "")
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_dol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == 48 && txt_dol.Text == "")
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_P_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == 48 && txt_P.Text == "")
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_k_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == 48 && txt_rub.Text == "")
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_n_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == 48 && txt_rub.Text == "")
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void bt_res_Click(object sender, EventArgs e)
        {
            txt_out1.Text = "";
            txt_out2.Text = "";
            txt_out3.Text = "";
            txt_P.Text = "";
            txt_k.Text = "";
            txt_rub.Text = "";
            txt_dol.Text = "";
            txt_n.Text = "";
            txt_stonks.Text = "";


        }
    }
}
