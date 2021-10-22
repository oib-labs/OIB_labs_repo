using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace OIB_lab_2
{
    public partial class Form1 : Form
    {
        private int user_num1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExcelHelper helper = new ExcelHelper())
                {
                    if (helper.Open(filePath: Path.Combine("C:/Users/denis/Desktop", "Tab2.xlsx")))
                    {
                        //helper.Set(column: "A", row: 1, data: "lksadklsajdkl");
                        //TbID1.Text= (String)helper.Get(column: "A", row: 1);
                        //helper.Set(column: "B", row: 1, data: DateTime.Now);
                        //helper.Save();
                        String Inp_ID = TbID1.Text;
                        String Inp_pass = TbPass1.Text;
                        user_num1 = Convert.ToInt32(helper.Get("K", 1));
                        if (user_num1 == 0)
                        {
                            MessageBox.Show("База данных пуста", "Предупреждение",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            int flag = 0;

                            for (int i=1; i<=user_num1; i++)
                            {
                                if (Inp_ID.Equals(helper.Get("A", i))
                                    && Inp_pass.Equals(helper.Get("B", i)))
                                {
                                    Form4 f4 = new Form4(i);
                                    f4.Show();
                                    break;
                                }
                                else
                                {
                                    /*MessageBox.Show("Неверно введены данные", "Предупреждение",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
                                    flag++;
                                    
                                }
                                
                            }
                            if (flag == user_num1)
                                MessageBox.Show("Неверно введены данные", "Предупреждение",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void BtnChangePass1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
    
}
