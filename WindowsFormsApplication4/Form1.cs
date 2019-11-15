using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public float FirstCount;
        public int Operations;
        public bool PositiveOrNegativeNumber = true;
        public float SecondCount;
        public int Result = 0;
        public string Interface;
        

        public Form1()
        {
            InitializeComponent();
        }

        public void calculate()
        {

            switch (Operations)
            {
                case 1:
                    SecondCount = FirstCount + float.Parse(result.Text);
                    result.Text = SecondCount.ToString();
                    break;
                 
                case 2:
                    SecondCount = FirstCount - float.Parse(result.Text);
                    result.Text = SecondCount.ToString();
                    break;
                case 3: 
                    SecondCount = FirstCount * float.Parse(result.Text);
                    result.Text = SecondCount.ToString();
                    break;
                case 4:
                    SecondCount = FirstCount / float.Parse(result.Text);
                    result.Text = SecondCount.ToString();
                    break;
                case 5:
                    SecondCount = (float.Parse(result.Text) / 100) * FirstCount;
                    result.Text = SecondCount.ToString();
                    break;
                default:
                    break;
            }


        }
        
        
        private void equolly_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = " ";
            

        }
        private void One_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "1";


        }

        private void Two_B_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "2";

        }

        private void Three_B_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "3";


        }

        private void Four_B_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "4";


        }

        private void Five_B_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "5";
        }

        private void Six_B_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "6";
        }

        private void Seven_B_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "7";
        }

        private void Eight_B_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "8";
        }

        private void Nine_B_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "9";
        }

        private void Zero_B_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + "0";

        }
        
        private void Plus_Click(object sender, EventArgs e)
        {
            FirstCount = float.Parse(result.Text);
            label1.Text += " + ";
            if (FirstCount < 0)
            {
                PositiveOrNegativeNumber = false;
            }
            else
            {

                PositiveOrNegativeNumber = true;
            }
            Operations = 1;
            result.Text = "";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            FirstCount = float.Parse(result.Text);
            label1.Text += " - ";
            if (FirstCount < 0)
            {
                PositiveOrNegativeNumber = false;
            }
            else
            {

                PositiveOrNegativeNumber = true;
            }
            Operations = 2;
            result.Text = "";
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            FirstCount = float.Parse(result.Text);
            label1.Text += " * ";
            if (FirstCount < 0)
            {
                PositiveOrNegativeNumber = false;
            }
            else
            {

                PositiveOrNegativeNumber = true;
            }
            Operations = 3;
            result.Text = "";
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            FirstCount = float.Parse(result.Text);
            label1.Text += " / ";
            if (FirstCount < 0)
            {
                PositiveOrNegativeNumber = false;
            }
            else
            {

                PositiveOrNegativeNumber = true;
            }
            Operations = 4;
            result.Text = "";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(result.Text))
            {
                label1.Text = "";
                FirstCount = 0;

            }

            result.Text = "";

        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            result.Text = result.Text + ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "-" + result.Text;
        }

        private void PersentButton_Click_1(object sender, EventArgs e)
        {

            Operations = 5;
            FirstCount = float.Parse(result.Text);
            label1.Text += " % ";
            if (FirstCount < 0)
            {
                PositiveOrNegativeNumber = false;
            }
            else
            {

                PositiveOrNegativeNumber = true;
            }

            result.Text = "";

        }   
    }
}
