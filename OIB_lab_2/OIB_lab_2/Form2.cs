using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OIB_lab_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSave2_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExcelHelper helper = new ExcelHelper())
                {
                    if (helper.Open(filePath: Path.Combine("C:/Users/denis/Desktop", "Tab2.xlsx")))
                    {
                        int user_num2 = Convert.ToInt32(helper.Get("K", 1))+1;
                        helper.Set("A", user_num2, Convert.ToString(TbID2.Text));
                        helper.Set("B", user_num2, Convert.ToString(TbPass2.Text));
                        helper.Set("C", user_num2, Convert.ToString(TbSurname2.Text));
                        helper.Set("D", user_num2, Convert.ToString(TbName2.Text));
                        helper.Set("E", user_num2, Convert.ToString(TbOtch2.Text));
                        helper.Set("F", user_num2, Convert.ToString(TbBornDate2.Text));
                        helper.Set("G", user_num2, Convert.ToString(TbBornPlace2.Text));
                        helper.Set("H", user_num2, Convert.ToString(TbPhone2.Text));
                        helper.Save();
                        helper.Dispose();
                    }
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
