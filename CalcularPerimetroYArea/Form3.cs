﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcularAreaYPerimetro;

namespace CalcularPerimetroYArea
{
    /// <summary>
    /// Clase que servirá como vista nueva para el círculo, se encargara de recoger los datos del usuario y mandarlos a un objeto de la figura. Es llamada desde el form principal.
    /// </summary>
    public partial class Form3 : Form
    {
        /// <summary>
        /// Variable de tipo Float donde se guardara el radio del círculo que introduzca el usuario.
        /// </summary>
        private float radio;

        /// <summary>
        /// Variable de la clase círculo que permite modificarla mediante sus setters.
        /// </summary>
        private Círculo cr = new Círculo();

        /// <summary>
        /// Metodo que inicializa los componentes.
        /// </summary>
        public Form3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que permite volver a la vista anterior al hacer click en el botón atrás.
        /// </summary>
        /// <param name="sender">Objeto que llama al evento.</param>
        /// <param name="e">Argumentos con los que se llama al evento.</param>
        private void btnBackRec_Click(object sender, EventArgs e)
        {
            this.Close();
            formPrincipal fPrin = new formPrincipal();
            fPrin.Show();
        }

        /// <summary>
        /// Metodo que calculará el perímetro y el área de un círculo, controlará que el usuario no pueda introducir cadenas o numeros negativos ni ceros lanzando un mensaje de aviso.
        /// </summary>
        /// <param name="sender">Objeto que llama al evento.</param>
        /// <param name="e">Argumentos con los que se llama al evento.</param>
        private void btnCir_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tbRadioCir.Text, out radio))
            {

                if (radio > 0)
                {
                    cr.Radio = radio;
                    
                    lblCirAreaCalculated.Text = "Área: " + cr.Area();
                    lblCirPerCalculated.Text = "Perímetro: " + cr.Perimeter();

                }
                else
                {
                    lblCirPerCalculated.Text = "El radio no pueden ser negativo.";
                    lblCirAreaCalculated.Text = "";
                }


            }
            else
            {
                lblCirPerCalculated.Text = "Datos invalidos, introduzca un número.";
                lblCirAreaCalculated.Text = "";
            }
        }

    }
}
