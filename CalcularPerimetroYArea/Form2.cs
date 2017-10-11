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
    /// Clase que servirá como vista nueva para el rectángulo, se encargara de recoger los datos del usuario y mandarlos a un objeto de la figura. Es llamada desde el form principal.
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// Variable de la clase rectángulo que permite modificarla mediante sus setters.
        /// </summary>
        private Rectángulo rec = new Rectángulo();

        /// <summary>
        /// Variable de tipo Float donde se guardara la altura del rectángulo que introduzca el usuario.
        /// </summary>
        private float altura;

        /// <summary>
        /// Variable de tipo Float donde se guardara la altura del rectángulo que introduzca el usuario.
        /// </summary>
        private float baseR;

        /// <summary>
        /// Metodo que inicializa los componentes.
        /// </summary>
        public Form2()
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
        /// Metodo que calculará el perímetro y el área de un Rectángulo, controlará que el usuario no pueda introducir cadenas o numeros negativos ni ceros lanzando un mensaje de aviso.
        /// </summary>
        /// <param name="sender">Objeto que llama al evento.</param>
        /// <param name="e">Argumentos con los que se llama al evento.</param>
        private void btnRec_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tbRecAltura.Text, out altura)&& float.TryParse(tbRecAnchura.Text, out baseR))
            {

                if (altura > 0 || baseR > 0)
                {
                    rec.Height = altura;
                    rec.Weight = baseR;
                    lblRecAreaCalculated.Text = "Área: " + rec.Area();
                    lblRecPerCalculated.Text = "Perímetro: " + rec.Perimeter();

                }
                else
                {
                    lblRecPerCalculated.Text = "Los datos no pueden ser negativos.";
                    lblRecAreaCalculated.Text = "";
                }


            }
            else
            {
                lblRecPerCalculated.Text = "Datos invalidos, introduzca un número.";
                lblRecAreaCalculated.Text = "";
            }
        }
    }
}
