using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R22A1_FranGV
{
    public class Rectangulo : Forma
    {

        // MIEMBROS 

        private float _ladoMenor;

        private float _ladoMayor;


        // CONSTRUCCTORES

        // PROPIEDADES

        public float LadoMenor
        {
            get
            {
                return _ladoMenor;
            }
            set
            {
                _ladoMenor = value;
            }
        }

        public float LadoMayor
        {
            get 
            {
            return _ladoMayor;
            }
            set
            {
                _ladoMayor = value;
            }
        }


        // MÉTODOS PÚBLICOS/PRIVAVADOS



        public float area()
        {
            // recursos

            float area = 0;

            // proceso

            area = LadoMenor * _ladoMayor;

            // salida

            return area;
        }

        public float perimetro()
        {
            // recursos

            float perimetro = 0;

            // proceso

            perimetro = ((2 * LadoMayor) + (2 * LadoMenor));

            // salida

            return perimetro;
        }

        public static float CambiarTamañoLadoMayor(float escala, float ladomayor)
        {
            // RECURSOS

            float resultado = 0;

            // PROCESO

           resultado = escala * ladomayor;

            // SALIDA

            return resultado;
        }


        public static float CambiarTamañoLadoMenor(float escala, float ladomenor)
        {
            // RECURSOS

            float resultado = 0;

            // PROCESO

            resultado = escala * ladomenor;

            // SALIDA

            return resultado;
        }

        public override string ToString()
        {
            // recursos

            string cadena = "";

            // salida

            cadena = $"se trata de un rectangulo";
            cadena += $"{Nombre}, {Color}, {Punto.X}";

            return cadena;
        }



    }
}
