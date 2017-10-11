using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaYPerimetro
{
    /// <summary>
    /// Clase Rectángulo que hereda de la Clase Figura, permite calcular el area y el perimetro de un rectangulo.
    /// </summary>
    class Rectángulo : Figura
    {

        /// <summary>
        /// Es la variable de tipo Float que hace referencia a la altura del rectángulo.
        /// </summary>
        float height;

        /// <summary>
        /// Es la variable de tipo Float que hace referencia a la anchura del rectángulo.
        /// </summary>
        float weight;

        /// <summary>
        /// Metodo de tipo Float que permite calcular el área de un rectángulo, siendo la suma de la base y la altura por dos.
        /// </summary>
        /// <returns></returns>
        public override float Perimeter()
        {
            return (height + weight)*2;
        }

        /// <summary>
        /// Metodo de tipo Float que permite calcular el área de un rectángulo, siendo el producto de la altura y la base.
        /// </summary>
        /// <returns></returns>
        public override float Area()
        {
            return height * weight;
        }


        /// <summary>
        /// Set para la base del rectángulo. Si se intenta introducir un valor negativo la variable sera 0.
        /// </summary>
        public float Weight
        {
            set
            {
                if (value < 0) weight = 0;
                else weight = value;

            }
        }

        /// <summary>
        /// Set para la altura del rectángulo. Si se intenta introducir un valor negativo la variable sera 0.
        /// </summary>
        public float Height
        {
            set
            {
                if (value < 0) height = 0;
                else height = value;

            }
        }


    }
}
