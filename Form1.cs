using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int b = int.Parse(textBox2.Text);   
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double soma = a + b;

            MessageBox.Show($"A Soma é: {soma}");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double sub = a - b;

            MessageBox.Show($"O resultado da Subtração é: {sub}");  
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double mult = a * b;

            MessageBox.Show($"O resultado da Multiplicação é: {mult}");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double div = a / b;

            MessageBox.Show($"O resultado da divisão é: {div}");
        }
    }
}
