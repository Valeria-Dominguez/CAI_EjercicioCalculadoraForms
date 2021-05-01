using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora.Libreria.Entidades;
using Calculadora.Libreria.Validaciones;


namespace Calculadora.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                double NumeroA = Validaciones.ValidarDouble(txtNumeroA.Text);
                double NumeroB = Validaciones.ValidarDouble(txtNumeroB.Text);
                Validaciones.ValidarOperador(txtOperador.Text);

                Calculo calculo = new Calculo(NumeroA, NumeroB, txtOperador.Text);

                MessageBox.Show($"Resultado: {calculo.Resultado.ToString()}");

                Limpiar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void Limpiar()
        {
            txtNumeroA.Text = string.Empty;
            txtNumeroB.Text = string.Empty;
            txtOperador.Text = string.Empty;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            txtOperador.Text = "+";
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            txtOperador.Text = "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtOperador.Text = "*";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtOperador.Text = "/";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
