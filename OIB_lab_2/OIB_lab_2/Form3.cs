using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OIB_lab_2
{
    public partial class Form3 : Form
    {
        private Person person;
        public Form3(Person pers)
        {
            person = pers;
            InitializeComponent();
        }

        private void BtnSave3_Click(object sender, EventArgs e)
        {
            if (TbNewPass3.Text.Length < 8)
            {
            }
        }
    }
}
