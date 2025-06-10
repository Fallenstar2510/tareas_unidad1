using System.Security.Cryptography.X509Certificates;

namespace gym
{
    public partial class Form1 : Form
    {
        public float numero1, numero2, resultadodemulti;
        public Form1()
        {
            InitializeComponent();





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void resultado_TextChanged(object sender, EventArgs e)
        {
            // resultado.Text = ("mmg");
        }


        public void multiplicar()
        {
            //  resultadodemulti = numero1 + numero2;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            numero1 = int.Parse(num.Text);
            numero2 = int.Parse(num1.Text);
            resultadodemulti = numero1 * numero2;
            resultado.Text = (resultadodemulti.ToString());
        }

        private void num_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
