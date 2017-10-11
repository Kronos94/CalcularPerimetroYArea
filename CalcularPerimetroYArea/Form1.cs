using System;
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
    /// Clase que servirá como vista nueva para el triángulo, se encargara de recoger los datos del usuario y mandarlos a un objeto de la figura. Es llamada desde el form principal.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Variable de la clase tríangulo que permite modificarla mediante sus setters.
        /// </summary>
        private Triángulo tr = new Triángulo();

        /// <summary>
        /// Variable de tipo Float donde se guardara el lado A que introduzca el usuario.
        /// </summary>
        private float a;

        /// <summary>
        ///  Variable de tipo Float donde se guardara el lado B que introduzca el usuario.
        /// </summary>
        private float b;

        /// <summary>
        ///  Variable de tipo Float donde se guardara el lado C que introduzca el usuario.
        /// </summary>
        private float c;

        /// <summary>
        /// Variable de tipo Float donde se guardara la altura del triángulo que introduzca el usuario.
        /// </summary>
        private float altura;

        /// <summary>
        /// Variable de tipo Float donde se guardara la base del triángulo que introduzca el usuario.
        /// </summary>
        private float baseT;


        /// <summary>
        /// Metodo que inicializa los componentes.
        /// </summary>
        public Form1()
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
        /// Metodo que calculará el área de un triángulo, controlará que el usuario no pueda introducir cadenas o numeros negativos ni ceros lanzando un mensaje de aviso.
        /// </summary>
        /// <param name="sender">Objeto que llama al evento.</param>
        /// <param name="e">Argumentos con los que se llama al evento.</param>
        private void btnTriArea_Click(object sender, EventArgs e)
        {

            if (float.TryParse(tbAlturaTri.Text, out altura) &&
                float.TryParse(tbBaseTri.Text, out baseT))
            {

                if (altura > 0 || baseT > 0)
                {
                    tr.Height = altura;
                    tr.BaseTri = baseT;
                    lblTriCalculatedArea.Text = "Área: " + tr.Area();

                }
                else
                {
                    lblTriCalculatedPer.Text = "Los lados no pueden ser negativos.";
                    lblTriCalculatedArea.Text = "";
                }


            }
            else
            {
                lblTriCalculatedPer.Text = "Datos invalidos, introduzca un número.";
                lblTriCalculatedArea.Text = "";
            }
        }

        /// <summary>
        /// Metodo que calculará el perímetro de un triángulo, controlará que el usuario no pueda introducir cadenas o numeros negativos ni ceros lanzando un mensaje de aviso.
        /// </summary>
        /// <param name="sender">Objeto que llama al evento.</param>
        /// <param name="e">Argumentos con los que se llama al evento.</param>
        private void btnTriPer_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tbLadoATri.Text, out a) &&
                float.TryParse(tbLadoBTri.Text, out b) &&
                float.TryParse(tbLadoCTri.Text, out c))
            {

                if (a > 0 && b > 0 && c > 0)
                {
                    tr.A = a;
                    tr.B = b;
                    tr.C = c;
                    lblTriCalculatedPer.Text = "Perímetro: " + tr.Perimeter();

                }
                else
                {
                    lblTriCalculatedPer.Text = "Los lados no pueden ser negativos.";
                }


            }
            else
            {
                lblTriCalculatedPer.Text = "Datos invalidos, introduzca un número.";
            }
        }
    }


}
