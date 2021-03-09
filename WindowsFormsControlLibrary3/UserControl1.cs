using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary3
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            

        }

        public static bool correcto;
        public static bool correcto2;
        public static bool correcto3;


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text == "1234567B")
            {
                correcto = true;
            }
            else
            {
                correcto = false;
            }

            booleanosCorrectos();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text == "ABCD")
            {
                correcto2 = true;
            }
            else
            {
                correcto2 = false;
            }

            booleanosCorrectos();


        }


        private void booleanosCorrectos()
        {
            if (correcto3==true && correcto==true && correcto2==true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox3.Text == "123")
            {
                correcto3 = true;
            }
            else
            {
                correcto3 = false;
            }

            booleanosCorrectos();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
