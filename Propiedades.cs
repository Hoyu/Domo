using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Propiedades
    {
        private string codigo;
        private string tipo;
        private int locationX, locationY;

        public Propiedades(string codigo)
        {
            this.codigo = codigo;
        }

        public string getCodigo()
        {
            return codigo;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string getTipo()
        {
            return tipo;
        }

        public void setLocationX(int locationX)
        {
            this.locationX = locationX;
        }

        public int getLocationX()
        {
            return locationX;
        }

        public void setLocationY(int locationY)
        {
            this.locationY = locationY;
        }

        public int getLocationY()
        {
            return locationY;
        }
    }
}
