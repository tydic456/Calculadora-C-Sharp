using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        //Declarando objeto para fazer as contas
        DataTable table = new DataTable();

        //Declarando funções de cada botão
        private void btn1_Click(object sender, EventArgs e)
        {
            //Mostra o botão clicado
            txbResultado.Text = "1";
            //Adciona o conteúdo do botão ao histórico
            lbl_hist.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "2";
            lbl_hist.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "3";
            lbl_hist.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "4";
            lbl_hist.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "5";
            lbl_hist.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "6";
            lbl_hist.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "7";
            lbl_hist.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "8";
            lbl_hist.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "9";
            lbl_hist.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "0";
            lbl_hist.Text += "0";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {   
            lbl_hist.Text += "+";
            //Limpa a caixa de resultado
            txbResultado.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //Tenta fazer a conta com o conteúdo contido no histórico, com preferência nas operações de multiplicação e divisão
            try
            {
                txbResultado.Text = table.Compute(lbl_hist.Text, "") + "";
                
            }
            //Caso não seja possivel efetuar tal conta, mostrará a seguinte mensagem
            catch
            {
                txbResultado.Text = "Erro";
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            lbl_hist.Text += "-";
            txbResultado.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            lbl_hist.Text += "*";
            txbResultado.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        { 
            lbl_hist.Text += "/";
            txbResultado.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbResultado.Clear();
            //Limpa o histórico
            lbl_hist.Text = "";
        }
    }
}
