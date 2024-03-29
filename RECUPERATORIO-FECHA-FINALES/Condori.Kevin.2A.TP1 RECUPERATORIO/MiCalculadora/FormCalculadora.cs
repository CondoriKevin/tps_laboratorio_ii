﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        string[] opArray = new string[] { "", "+", "-", "*", "/" }; //dejamos el espacio vacio por que asi lo pide en el tp

        /// <summary>
        /// Constructor del FormCalculadora.
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();     
        }

        /// <summary>
        /// Al cargar va a llenar los valores de cmbOperandor con el apArray y vamos a limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.Items.AddRange(opArray);
            Limpiar();
            
        }

        /// <summary>
        /// pregunta si queres sacar el fomr, tal cual lo pide en la consigna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro de querer salir?", "Salir",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// borra todos los datos que vemos en pantalla
        /// </summary>
        private void Limpiar()
        {
            lstOperaciones.Items.Clear();
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.SelectedIndex = -1;
            lblResultado.Text = "0";
            
        }

        /// <summary>
        /// llammamos al metodo limpiar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// vemos que opcion vamos a OPerar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string op = cmbOperador.Text;

            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            if (op == "")
            {
                op = "+";
            }
            lstOperaciones.Items.Add($"{ValidarTxtBox(txtNumero1.Text.Replace(".", ","))} {op} {ValidarTxtBox(txtNumero2.Text.Replace(".", ","))} = {lblResultado.Text.Replace(".", ",")}");
        }

        /// <summary>
        /// recibimos los numero y realizacion la operacion solicitada
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            char[] caracterArray = operador.ToCharArray();
            if (caracterArray.Length == 0)
            {
                operador = "+";
            }
    
            return Calculadora.Operar(num1, num2, operador.ToCharArray()[0]);
        }

        /// <summary>
        /// pasamos a ninario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultado = Operando.DecimalBinario(lblResultado.Text);
            lstOperaciones.Items.Add($"{lblResultado.Text} = {resultado}");
            lblResultado.Text = resultado;
        }

        /// <summary>
        /// pasamos a decimal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultado = Operando.BinarioDecimal(lblResultado.Text);
            lstOperaciones.Items.Add($"{lblResultado.Text} = {resultado}");
            lblResultado.Text = resultado;
        }

        /// <summary>
        /// validamos de tener datos numericos de lo contrario retirna 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarTxtBox(string strNumero)
        {
            if(!double.TryParse(strNumero, out double retorno))
            {
                retorno = 0;
            }

            return retorno;
        }
    }
}
