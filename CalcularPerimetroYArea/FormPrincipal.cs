using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularPerimetroYArea
{
    /// <summary>
    /// Clase que será la vista principal del programa, en el elegiremos para que figura queremos calcular el área y el périmetro.
    /// </summary>
    public partial class formPrincipal : Form
    {
        /// <summary>
        /// Metodo que inicializa los componentes.
        /// </summary>
        public formPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que recoge el elemento elegido en el combo box y lanza la vista que desea el usuario. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formChanged(object sender, EventArgs e)
        {

            if (((ComboBox)sender).Text == "Rectángulo")
            {
                Form2 fRec = new Form2();
                fRec.Show();
                this.Hide();

            }
            else if (((ComboBox)sender).Text == "Círculo")
            {
                Form3 fCir = new Form3();
                fCir.Show();
                this.Hide();
            }
            else
            {
                Form1 fTri = new Form1();
                fTri.Show();
                this.Hide();
            }

        }


    }
}
