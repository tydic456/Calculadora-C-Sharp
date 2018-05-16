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
        double valor = 0;
        string operacao = "";
        public frmCalc()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "0";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            valor += double.Parse(txbResultado.Text);
            txbResultado.Text = "+";
            operacao = "+";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                valor += double.Parse(txbResultado.Text);
                txbResultado.Text = valor.ToString();
                valor = 0;
            }
            else if (operacao == "x")
            {
                valor *= double.Parse(txbResultado.Text);
                txbResultado.Text = valor.ToString();
                valor = 0;
            }
            else if (operacao == "-")
            {
                valor -= double.Parse(txbResultado.Text);
                txbResultado.Text = valor.ToString();
                valor = 0;
            }
            else if (operacao == "/")
            {
                valor /= double.Parse(txbResultado.Text);
                txbResultado.Text = valor.ToString();
                valor = 0;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            valor += double.Parse(txbResultado.Text);
            txbResultado.Text = "-";
            operacao = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            valor += double.Parse(txbResultado.Text);
            txbResultado.Text = "x";
            operacao = "x";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor += double.Parse(txbResultado.Text);
            txbResultado.Text = "/";
            operacao = "/";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "";
        }
    }
}
