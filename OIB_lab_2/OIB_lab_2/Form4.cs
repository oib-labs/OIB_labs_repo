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
    public partial class Form4 : Form
    {
        //private Form1 f1;
        //private int index;
        //private Person person;
        private int user_num4;
        public Form4(int user_num4)
        {
            this.user_num4 = user_num4;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                using (ExcelHelper helper = new ExcelHelper())
                {
                    if (helper.Open(filePath: Path.Combine("C:/Users/denis/Desktop", "Tab2.xlsx")))
                    {
                        LblName4.Text = (String)helper.Get("D", user_num4);
                        TbSurname4.Text = (String)helper.Get("C", user_num4);
                        TbOtch4.Text = (String)helper.Get("E", user_num4);
                        helper.Dispose();
                    }
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}

