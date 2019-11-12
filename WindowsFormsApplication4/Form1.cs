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
        const int One = 1;
        const int Two = 2;
        const int Three = 3;
        const int Four = 4;
        const int Five = 5;
        const int Six = 6;
        const int Seven = 7;
        const int Eight = 8;
        const int Nine = 9;
        const int Zero = 0;
        chars Char = new chars();


        public Form1()
        {
            InitializeComponent();
        }

        public void calculate()
        {
            int count = 1;        
            switch (count)
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
                default:
                    break;
            }


        }
        public void Operation(bool plusFlag, int number)
        {
            if (Result == 0)
            {

                // Работа с чслом и сложение
                result.Text += One.ToString();
                Result = One;
            }
            //else
            //{
            //    result.Clear();
            //}
            if (plusFlag)
            {
                Result += number;
                result.Text += number.ToString();
                
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
        }
    }
}
