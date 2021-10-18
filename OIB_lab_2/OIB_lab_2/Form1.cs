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
    public partial class Form1 : Form
    {
        /*private ArrayList AL;
        private Person person;
        private int PersonIndex;*/
        public PersonCheck personCheck1 = new PersonCheck();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LblError.Text = "";
            String ID = TbID1.Text;
            String Pass = TbPass1.Text;
            LblError.Text = personCheck1.CheckPerson(ID, Pass);
            if (personCheck1.CheckPerson(ID, Pass).Equals(""))
            {
                int index = personCheck1.GetPersonIndex(ID, Pass);
                ArrayList arrayList = personCheck1.GetPersonList();
                Person person = (Person)arrayList[index];
                Form4 f4 = new Form4(person);
                f4.Show();

            }
        }

        private void BtnChangePass1_Click(object sender, EventArgs e)
        {
            String ID = TbID1.Text;
            String Pass = TbPass1.Text;
            //PersonCheck personCheck = new PersonCheck();
            int index = personCheck1.GetPersonIndex(ID, Pass);
            ArrayList arrayList = personCheck1.GetPersonList();
            Person person = (Person)arrayList[index];
            Form3 f3 = new Form3(person);
            f3.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(personCheck1);
            f2.Show();
        }
    }
    
}
