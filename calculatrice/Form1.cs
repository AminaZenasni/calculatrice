using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatrice
{
    public partial class calculatrice : Form
    {
        double FirstNumber;
        string Op;
        public calculatrice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void MOINS_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);           
            Op = "-";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "8";
        }

        private void PLUS_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            Op = "+";
        }

        private void SIMA_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            Op = "/";
        }
         private void button2_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Op == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Op=="-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            if (Op == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
    }
}
