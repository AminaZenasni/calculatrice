using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace calculatrice
{
    public partial class calculatrice : Form
    {
        double FirstNumber;
        string Operation;
        public calculatrice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null) 
            {                                                   
                textBox1.Text = "1";                            
            }
            else
            {                                                   
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void BTN0_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void PLUS_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        private void MOINS_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void _Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void SIMA_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }
        private void BTNMUL_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void BTNC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void EGALE_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double ThirdNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);
            ThirdNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber );
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "/")
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
