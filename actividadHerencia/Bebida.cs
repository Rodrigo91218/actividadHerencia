using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadHerencia
{
    internal class Bebida
    {
        private string nombre;
        private int cant;

        public Bebida(string nombre, int cant)
        {
            this.nombre = nombre;
            this.cant = cant;
        }
        public Bebida()
        {
            this.nombre = "";
            this.cant = 0;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cant { get => cant; set => cant = value; }
    }
}
