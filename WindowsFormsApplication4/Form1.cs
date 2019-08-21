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
        public bool MinusFlag = false;
        public bool PlusFlag = false;
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
        List<string> OperationsList = new List<string>();
        public void Operation(bool plusFlag, int number)
        {
            if (Result == 0)
            {

                // Работа с чслом и сложение
                result.Text += One.ToString();
                Result = One;
            }
            if (plusFlag)
            {
                Result += number;
                result.Text += number.ToString();
            }
        }


        private void One_Click(object sender, EventArgs e)
        {
            
            Operation(PlusFlag, One);
        }

        private void Plus_Click(object sender, EventArgs e)
        {

            result.Text += " - ";
            OperationsList.Add("minus");

        }

        private void equolly_Click(object sender, EventArgs e)
        {
            result.Clear();
            result.Text = Result.ToString();
            foreach (String oper in OperationsList)
            {

            }
            

        }

        private void Two_B_Click(object sender, EventArgs e)
        {
            Operation(PlusFlag, Two);
        }

        private void Three_B_Click(object sender, EventArgs e)
        {
            Operation(PlusFlag, Three);

        }

        private void Four_B_Click(object sender, EventArgs e)
        {
            Operation(PlusFlag, Four);

        }

        private void Five_B_Click(object sender, EventArgs e)
        {
            Operation(PlusFlag, Five);

        }

        private void Six_B_Click(object sender, EventArgs e)
        {
            Operation(PlusFlag, Six);

        }

        private void Seven_B_Click(object sender, EventArgs e)
        {
            Operation(PlusFlag, Seven);

        }

        private void Eight_B_Click(object sender, EventArgs e)
        {
            Operation(PlusFlag, Eight);

        }

        private void Nine_B_Click(object sender, EventArgs e)
        {
            Operation(PlusFlag, Nine);

        }

        private void Zero_B_Click(object sender, EventArgs e)
        {
            Operation(PlusFlag, Zero);

        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            result.Text += " - ";
            OperationsList.Add("minus");

        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {

        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
