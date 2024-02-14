using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R22A1_FranGV
{

    public enum TipoCoordenada : Byte { X, Y };

    public class Punto 
    {

        // MIEMBROS PRIVADOS

        private float _x;
        private float _y;

        #region CONSTRUCTORES

        public Punto()
        {
            _x = 0.0f;
            _y = 0.0f;
        }

        /// <summary>
        /// Inicializa el Punto con una coordenada
        /// </summary>
        /// <param name="tipo">Coordenada a establecer</param>
        /// <param name="coordenada">Valor de la coordenada</param>
        public Punto(TipoCoordenada tipo, float coordenada) : this() // Reutiliza el constructor por defecto
        {

            switch (tipo)
            {
                case TipoCoordenada.X:
                    X = coordenada;
                    break;
                case TipoCoordenada.Y:
                    Y = coordenada;
                    break;
            }
        }


        public Punto(float coordenadaX, float coordenadaY)
        {
            X = coordenadaX;
            Y = coordenadaY;   
        }

        #endregion

        // PROOPIEDADES

        public float X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
