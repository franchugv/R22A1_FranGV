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

        public Rectangulo(float ladomayor, float ladoomenor) : base() // Usa el constructor por defecto de la clase padre/base
        {

            //Nombre = VALOR_DEFECTO;
            //Color = VALOR_DEFECTO;
            //Mover(new Punto());     // Hay que instanciar un nuevo punto



            LadoMayor = ladomayor;
            LadoMenor = ladoomenor;
        }

        //public Rectangulo(float ladoMenor, float ladoMayor, string nombre, string color, Punto posicion) : this(ladoMayor, ladoMenor) // despues de los dos puntos se ejecuta antes.
        //{

        //    Nombre = nombre;
        //    Color = color;
        //    Mover(posicion);

        //}


        public Rectangulo(float ladoMenor, float ladoMayor, string nombre, string color, Punto posicion) : base(nombre, color, posicion)
        {

            LadoMayor = ladoMayor;

            LadoMenor = ladoMenor;
        }


        // PROPIEDADES

        public float LadoMenor
        {
            get
            {
                return _ladoMenor;
            }
            set
            {
                ValidadLado(value);
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
                // VALIDAR LA ENTRADA (value)
                ValidadLado(value);
                _ladoMayor = value;
            }
        }



        public float Perimetro
        {
            get
            {
                return perimetro();
            }

        }

        public float Area
        {
            get
            {
                return area();
            }
        }


        // MÉTODOS PÚBLICOS/PRIVAVADOS

        private void ValidadLado(float lado)
        {
            if (lado <= 0) throw new Exception("Lado incorrecto cara pan");
        }
        
        private float area()
        {
            // recursos

            float area = 0;

            // proceso

            area = LadoMenor * _ladoMayor;

            // salida

            return area;
        }

        private float perimetro()
        {
            // recursos

            float perimetro = 0;

            // proceso

            perimetro = 2 * (LadoMayor + LadoMenor);

            // salida

            return perimetro;
        }

        public void CambiarTamanio(float factorEscala)
        {
            // Validación de la Escala
            try
            {
                ValidadLado(factorEscala);
            }
            catch(Exception error) 
            {
                throw new Exception("El factor de escala es incorrecto");
            }

            // CALCULO
            LadoMayor *= factorEscala;
            LadoMenor *= factorEscala;
        }


        public override string ToString()
        {
            // recursos

            string cadena = "";

            // salida

            cadena = base.ToString();
            cadena += $"\n Se trata de un Rectángulo de lados {LadoMayor}, {LadoMenor}";


            return cadena;
        }


    }
}
