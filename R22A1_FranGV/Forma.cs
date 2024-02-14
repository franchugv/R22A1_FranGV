using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R22A1_FranGV
{

    // ENUM


    public class Forma
    {

        // CONSTANSTES PRIVADOS 

        private const string VALOR_DEFECTO = "Desconocido";




        // MIEMBROS - CLASE -

        private string _color;
        private string _nombre ;
        private Punto _centro;






        // CONSTRUCCTORES


        public Forma()
        {

            _nombre = VALOR_DEFECTO;
            _color = VALOR_DEFECTO;
            _centro = new Punto(); // Ultiliza el valor del constructor por defecto de Punto

        }

        public Forma(string nombre, string color, Punto centro)
        {

            Nombre = nombre;
            Color = color;
            Mover(centro);

        }



        // PROPIEDADES



        public string Color
        {
            get
            {
                if (_color == VALOR_DEFECTO) throw new Exception("Color no establecido");
                return _color;
            }

            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Color: Cadena vacía");
                _color = value;
            }
        }
        public string Nombre
        {
            get 
            {
                if (_nombre == VALOR_DEFECTO) throw new Exception("Nombre no establecido");
                return _nombre;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Nombre: Cadena vacía");
                _nombre = value;
            }
        }

        public Punto Centro
        {
            get
            {
                return _centro;
            }

        }

        // MÉTODOS PÚBLICOS/PRIVADOS


        /// <summary>
        /// Establece el nuevo centro a la forma
        /// </summary>
        /// <param name="nuevaPosicion">Nueva posición del centro</param>
        public void Mover(Punto nuevaPosicion)
        {

            _centro = nuevaPosicion;

        }


        public override string ToString()
        {
            // return ($"La forma {Nombre} de color {Color} está situada en el punto x: {Punto.X} Y: {Punto.Y}");

            return ($"La forma {Nombre} de color {Color} está situada en el punto {Centro}");

        }


    }
}
