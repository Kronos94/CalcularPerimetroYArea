using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaYPerimetro
{
    /// <summary>
    /// Clase que hace referencia a un triángulo que hereda de la clase Figura y nos permitira calcular su área y perímetro.
    /// </summary>
    class Triángulo : Figura
    {
        /// <summary>
        /// Variable de tipo Float que hace referecia a a base de un triángulo.
        /// </summary>
        float baseTri;

        /// <summary>
        /// Variable de tipo Float que hace referecia a la altura de un triángulo.
        /// </summary>
        float height;

        /// <summary>
        /// Variable de tipo Float que hace referecia al lado A de un triángulo.
        /// </summary>
        float a;

        /// <summary>
        /// Variable de tipo Float que hace referecia al lado B de un triángulo.
        /// </summary>
        float b;

        /// <summary>
        /// Variable de tipo Float que hace referecia al lado C de un triángulo.
        /// </summary>
        float c;

        /// <summary>
        /// Metodo de tipo Float que permite calcular el perímetro de un triángulo, siendo la suma de todos sus lados.
        /// </summary>
        /// <returns>Devuelve el valor del perímetro.</returns>
        public override float Perimeter()
        {
            return a + b + c;
        }

        /// <summary>
        /// Metodo de tipo Float que permite calcular el área de un triángulo, siendo la base por la altura entre dos.
        /// </summary>
        /// <returns></returns>
        public override float Area()
        {
            return (baseTri * height) / 2;

        }

        /// <summary>
        /// Set para la base del triángulo. Si se intenta introducir un valor negativo la variable sera 0.
        /// </summary>
        public float BaseTri
        {
            set
            {
                if (value < 0) baseTri = 0;
                else baseTri = value;

            }
        }

        /// <summary>
        /// Set para la altura del triángulo. Si se intenta introducir un valor negativo la variable sera 0.
        /// </summary>
        public float Height
        {
            set 
            {
                if (value < 0) height = 0;
                else height = value;

            }
        }

        /// <summary>
        /// Set para el lado A del triángulo. Si se intenta introducir un valor negativo la variable sera 0.
        /// </summary>
        public float A
        {
            set
            {
                if (value < 0) a = 0;
                else a = value;

            }
        }

        /// <summary>
        /// Set para el lado B del triángulo. Si se intenta introducir un valor negativo la variable sera 0.
        /// </summary>
        public float B
        {
            set
            {
                if (value < 0) b = 0;
                else b = value;

            }
        }

        /// <summary>
        /// Set para el lado C del triángulo. Si se intenta introducir un valor negativo la variable sera 0.
        /// </summary>
        public float C
        {
            set
            {
                if (value < 0) c = 0;
                else c = value;

            }
        }
    }
}
