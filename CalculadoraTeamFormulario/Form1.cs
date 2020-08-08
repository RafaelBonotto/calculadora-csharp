using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTeamFormulario
{
    public partial class Form1 : Form
    {
        Calculadora calc;
        public Form1()
        {
            InitializeComponent();
            calc = new Calculadora();
        }//Fim do construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }//Carregar

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Campo para entrada do número 1

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Campo para entrada do número 2

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Campo para mostrar o resultado

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = "" + calc.Soma(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }catch(Exception erro)
            {
                MessageBox.Show("Um ou mais campos estão vazios");
            }
        }//Soma

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
                textBox3.Text = "" + calc.Subtracao(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }catch(Exception erro)
            {
                MessageBox.Show("Um ou mais campos estão vazios");
            }
        }//Subtração

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
                textBox3.Text = "" + calc.Multiplicacao(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }catch(Exception erro)
            {
                MessageBox.Show("Um ou mais campos estão vazios");
            }
        }//Multiplicação

        private void button4_Click(object sender, EventArgs e)
        {
            try { 
                textBox3.Text = "" + calc.Divisao(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }catch(Exception erro)
            {
                MessageBox.Show("Um ou mais campos estão vazios");
            }
        }//Divisão

        private void button5_Click(object sender, EventArgs e)
        {
            try { 
                textBox3.Text = "" + calc.Resto(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }catch(Exception erro)
            {
                MessageBox.Show("Um ou mais campos estão vazios");
            }
        }//Resto

        private void button6_Click(object sender, EventArgs e)
        {
            try { 
                textBox3.Text = "" + calc.Potencia(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }catch(Exception erro)
            {
                MessageBox.Show("Um ou mais campos estão vazios");
            }
        }//Potência

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }//Limpar


    }//fim da classe 
}//Fim do projeto
