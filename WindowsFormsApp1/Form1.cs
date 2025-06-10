using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public bool si = false,no = false;
        public float numero2,numero3,resultado1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (si == true && no==false )
            {

                numero.Text = numero.Text + "1";

            }
            else if (si == false && no==true ) 
            { 
            numero1.Text = numero1.Text + "1";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (si == true && no == false)
            {

                numero.Text = numero.Text + "2";

            }
            else if (si == false && no == true)
            {
                numero1.Text = numero1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (si == true && no == false)
            {

                numero.Text = numero.Text + "3";

            }
            else if (si == false && no == true)
            {
                numero1.Text = numero1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (si == true && no == false)
            {

                numero.Text = numero.Text + "4";

            }
            else if (si == false && no == true)
            {
                numero1.Text = numero1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (si == true && no == false)
            {

                numero.Text = numero.Text + "5";

            }
            else if (si == false && no == true)
            {
                numero1.Text = numero1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (si == true && no == false)
            {

                numero.Text = numero.Text + "6";

            }
            else if (si == false && no == true)
            {
                numero1.Text = numero1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (si == true && no == false)
            {

                numero.Text = numero.Text + "7";

            }
            else if (si == false && no == true)
            {
                numero1.Text = numero1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (si == true && no == false)
            {

                numero.Text = numero.Text + "8";

            }
            else if (si == false && no == true)
            {
                numero1.Text = numero1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (si == true && no == false)
            {

                numero.Text = numero.Text + "9";

            }
            else if (si == false && no == true)
            {
                numero1.Text = numero1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (si == true && no == false)
            {

                numero.Text = numero.Text + "0";

            }
            else if (si == false && no == true)
            {
                numero1.Text = numero1.Text + "0";
            }
        }

        private void numero_TextChanged(object sender, EventArgs e)
        {
          //  resultado.Text = "2000";
        }
        private void numero_GotFocus(object sender, EventArgs e)
        {
           
        }

        private void numero_Click(object sender, EventArgs e)
        {
            si = true;
            no = false;
        }

        private void numero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero1_Click(object sender, EventArgs e)
        {
            si = false;
            no = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numero2 = float.Parse(numero.Text);
            numero3 = float.Parse(numero1.Text);
            resultado1 = numero3 * numero2;
            resultado.Text = resultado1.ToString();
        }

        private void resultado_Click(object sender, EventArgs e)
        {
          
        }
    }
}
