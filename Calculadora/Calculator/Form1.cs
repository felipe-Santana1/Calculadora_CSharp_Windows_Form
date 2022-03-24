using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Operacao opera;
        int PrimeiroVALOR;
        int SegundoVALOR;
        int Resp;

        public Form1()
        {
            InitializeComponent();
            opera = new Operacao();
        }

        private void txtValorUM_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtValorDOIS_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            opera.ValorOne = Convert.ToInt32(txtValorUM.Text);
            opera.ValorTwo = Convert.ToInt32(txtValorDOIS.Text);

            opera.resposta = opera.ValorOne + opera.ValorTwo;
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            opera.ValorOne = Convert.ToInt32(txtValorUM.Text);
            opera.ValorTwo = Convert.ToInt32(txtValorDOIS.Text);
            opera.resposta = opera.ValorOne - opera.ValorTwo;
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            opera.ValorOne = Convert.ToInt32(txtValorUM.Text);
            opera.ValorTwo = Convert.ToInt32(txtValorDOIS.Text);
            opera.resposta = opera.ValorOne * opera.ValorTwo;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
           opera.ValorOne = Convert.ToInt32(txtValorUM.Text);
           opera.ValorTwo = Convert.ToInt32(txtValorDOIS.Text);
           opera.resposta = opera.ValorOne / opera.ValorTwo;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResult.Text = opera.resposta.ToString();
        }

    }
}
