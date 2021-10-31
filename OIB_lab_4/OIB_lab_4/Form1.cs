using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OIB_lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TbKSumm.Text = "0";
            TbGamming.Text = "0";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TbGamming_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbControlSumm_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //Метод контрольных сумм
            char[] CharArray = TbInput.Text.ToCharArray();
            int KSumm = 0;
            foreach (char symbol in CharArray)
            {
                KSumm += (int)symbol;
            }
            if (KSumm > 256)
            {
                TbKSumm.Text = Convert.ToString(KSumm % 256);
            }
            else
            {
                TbKSumm.Text = Convert.ToString(KSumm);
            }
            //Метод гаммирования
            TbGamming.Text = "";
            String text = TbInput.Text;
            int a = 31;
            int b = 7;
            int c = 256;
            int t0 = 126;
            List<int> arrayTs = new List<int>();
            arrayTs.Add(t0);
            List<int> res = new List<int>();
            for (int i = 0; i < text.Length; i++)
            {
                arrayTs.Add((a * arrayTs[i] + b) % c);
            }
            for (int i = 0; i < text.Length; i++)
            {
                int x = (int)text[i];
                x &= 0b1111111;
                int ti = arrayTs[i];
                ti &= 0b1111111;
                res.Add(x ^ ti);
            }
            TbGamming.Text = Convert.ToString(res.Sum()%256);
        }
    }
}
