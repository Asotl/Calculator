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

        private void One_Click(object sender, EventArgs e)
        {
            if  (Result == 0)
            {
                
                // Работа с чслом и сложение
                result.Text += One.ToString();
                Result = One;
            }
            if (PlusFlag)
            {
                Result += One;
                result.Text += One.ToString();
            }

       
        }

        private void Plus_Click(object sender, EventArgs e)
        {

            result.Text += " + ";
            PlusFlag = true;

        }

        private void equolly_Click(object sender, EventArgs e)
        {
            result.Clear();
            result.Text = Result.ToString();

        }
    }
}
