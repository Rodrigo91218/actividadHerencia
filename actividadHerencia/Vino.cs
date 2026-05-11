using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadHerencia
{
    internal class Vino:Bebida
    {
        private int cantCopas;
        private int año;

        public Vino(int cantCopas, int año)
        {
            this.cantCopas = cantCopas;
            this.año = año;
        }
        public Vino()
        {
            this.cantCopas = 0;
            this.año = 0;
        }

        public int CantCopas { get => cantCopas; set => cantCopas = value; }
        public int Año { get => año; set => año = value; }
    }
}
