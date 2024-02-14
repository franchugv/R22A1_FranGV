using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R22A1_FranGV
{
    public class Punto 
    {

        // MIEMBROS

        private float _x;
        private float _y;
        
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

    }
}
