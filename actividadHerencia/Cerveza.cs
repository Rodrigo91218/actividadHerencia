using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadHerencia
{
    internal class Cerveza:Bebida
    {
        private int cantLatas;
        private double ibur;

        public Cerveza(int cantLatas, double ibur)
        {
            this.cantLatas = cantLatas;
            this.ibur = ibur;
        }
        public Cerveza()
        {
            this.cantLatas = 0;
            this.ibur = 0;
        }

        public int CantLatas{ get => cantLatas; set => cantLatas = value; }
        public double Ibur { get => ibur; set => ibur = value; }
    }
}
