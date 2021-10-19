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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            
            String login_user = txt_login.Text;
            String password_user = txt_password.Text;
            
            Db db = new Db();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`= @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login_user;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password_user;
            try
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            catch {
                MessageBox.Show("Отсутствует соединение.");
            }

            if(table.Rows.Count > 0)
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.Show();
                form3.lab_login.Text = login_user;
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль.");
            }
        }
    }
}
