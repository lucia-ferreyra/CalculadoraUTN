using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraLF
{
    public partial class Form1 : Form
    {

        private double valor1;
        private double valor2;

        private double resultado;

        private int operacion;


        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //numero 00
            tbDisplay.Text = tbDisplay.Text + "00";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            //numero 0
            tbDisplay.Text = tbDisplay.Text + "0";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            //numero 1
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            //numero 2
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            //numero 3
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            //numero 4
            tbDisplay.Text = tbDisplay.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            //numero 5
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            //numero 6
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            //numero 7
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            //numero 8
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            //numero 9
            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            //boton limpiar todo
            tbDisplay.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //boton igual
            valor2 = Convert.ToDouble(tbDisplay.Text);

            resultado = valor1 + valor2;
            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    if (valor2 != 0) 
                    {
                        resultado = valor1 / valor2;
                        
                    }
                    else 
                    {
                        MessageBox.Show("Ingrese un valor distinto de 0");
                    }
                    break;

            }
            tbDisplay.Text = resultado.ToString();

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //boton suma
            operacion = 1;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //boton resta
            operacion = 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //boton multiplicacion
            operacion = 3;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //boton division
            operacion = 4;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            //boton decimal
            tbDisplay.Text = tbDisplay.Text + ",";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //boton clear
            if (tbDisplay.Text.Length == 1)
                tbDisplay.Text = "";
            else
                tbDisplay.Text = tbDisplay.Text.Substring(0, tbDisplay.Text.Length - 1);
        }
    }
}
