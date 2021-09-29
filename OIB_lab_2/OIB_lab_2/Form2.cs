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
    public partial class Form2 : Form
    {
        //Конструктор формы 2
        public Form2()
        {
            InitializeComponent();

            Form1 f1 = new Form1();
            Car car1 = f1.GetCar();
            tbWeight.Text = Convert.ToString(car1.GetWeight());
            tbYear.Text = Convert.ToString(car1.GetYear());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
