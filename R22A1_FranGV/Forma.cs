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

        // MIEMBROS - CLASE -

        private string _color;


        private string _nombre ;
        private Punto _centro;





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

        public Punto Punto
        {
            get => default;
            set
            {
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

        public void Mover(Punto nuevaPosicion)
        {
            throw new System.NotImplementedException();
        }
    }
}
