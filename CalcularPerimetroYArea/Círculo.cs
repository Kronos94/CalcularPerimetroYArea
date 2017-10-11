using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaYPerimetro
{
    /// <summary>
    /// Clase Círculo que hereda de la Clase Figura, permite calcular el area y el perimetro de un círculo.
    /// </summary>
    class Círculo : Figura
    {
        /// <summary>
        ///  Variable de tipo Float que hace referecia al radio de un círculo.
        /// </summary>
        float radio;

        /// <summary>
        ///  Variable de tipo double que hace referecia al numero PI necesario para hacer los calculos.
        /// </summary>
        const double PI = Math.PI;


        /// <summary>
        /// Metodo que calcula el área de un círculo, siendo el radio elevado al cuadrado por el numero PI.
        /// </summary>
        /// <returns>Devuele el valor calculado del perímetro en float.</returns>
        public override float Area()
        {
            double radioPow = Math.Pow(radio, 2.0);

            return Convert.ToSingle(radioPow * PI);

            

        }


        /// <summary>
        /// Metodo que calcula el périmetro de un círculo, siendo el producto del radio por PI por dos.
        /// </summary>
        /// <returns>Devuele el valor calculado del área en float.</returns>
        public override float Perimeter()
        {
            return Convert.ToSingle(2 * PI * radio);

        }

        /// <summary>
        /// Set para el radio del círculo. Si se intenta introducir un valor negativo la variable sera 0.
        /// </summary>
        public float Radio
        {
            set
            {
                if (value < 0) radio = 0;
                else radio = value;
            }
        }

    }
}
