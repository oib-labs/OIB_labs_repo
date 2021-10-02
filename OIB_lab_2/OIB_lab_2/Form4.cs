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

namespace OIB_lab_2
{
    public partial class Form4 : Form
    {
        //private Form1 f1;
        //private int index;
        private Person person;
        public Form4(Person pers)
        {
            //this.f1 = f1;
            person = pers;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            /*PersonCheck personCheck = new PersonCheck();
            ArrayList personList = personCheck.GetPersonList();
            Person person = (Person)personList[index];*/
            LblName4.Text = person.GetID();
            TbSurname4.Text = person.GetSurname();
            TbOtch4.Text = person.GetOtch();
        }
    }
}
