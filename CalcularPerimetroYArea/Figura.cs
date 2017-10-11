using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaYPerimetro
{
    /// <summary>
    /// Clase Figura de la cual heredarán las demas clases (triángulo, rectángulo y círculo) y que contiene los metodos virtuale que luego sobreescribirán sus hijos para calcular el perímetro y el área.
    /// </summary>
    class Figura
    {
        /// <summary>
        /// Metodo que sera heredado por los hijos para calcular el perímetro de cada uno de ellos.
        /// Sera un metodo vacio ya que la clase figura nunca sera usada y solo necesitamos que los hijos hereden 
        /// el metodo.
        /// </summary>
        /// <returns>Devuelve 0.</returns>
        public virtual float Perimeter()
        {
            return 0;
        }

        /// <summary>
        /// Metodo que sera heredado por los hijos para calcular el area de cada uno de ellos.
        /// Sera un metodo vacio ya que la clase figura nunca sera usada y solo necesitamos que los hijos obtengan 
        /// el metodo.
        /// </summary>
        /// <returns>Devuelve 0.</returns>
        public virtual float Area()
        {
            return 0;
        }


    }
}
