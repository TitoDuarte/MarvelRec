using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Figuras
    {
        public string nombre;
        public int precio;
        public string descripcion;
        public int existencia;
        public string franquicia;


        public Figuras(string franquicia, string nombre, string descripcion, int existencia, int precio)
        {
            this.franquicia = franquicia;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.existencia = existencia;
            this.precio = precio;
        }
    }


}
