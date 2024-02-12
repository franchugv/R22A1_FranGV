using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R22A1_FranGV
{

    // ENUM

    public enum _coordenada : byte { x, y };

    public class Forma
    {

        // MIEMBROS - CLASE -

        private string _color;


        private string _nombre ;

        // OBJETO

        Forma Punto = new Forma();


        // CONSTRUCCTORES


        // PROPIEDADES

        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }
        public string Nombre
        {
            get 
            { 
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        // MÉTODOS PÚBLICOS/PRIVADOS

        public override string ToString()
        {
            // recursos

            string cadena = "";

            // salida

            cadena = "";

            return cadena;
        }

    }
}
