using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadHerencia
{
    internal class Vino:Bebida, IGradoAlcohol
    {
        private int cantCopas;
        private int año;

        public int CantCopas { get => cantCopas; set => cantCopas = value; }
        public int Año { get => año; set => año = value; }

        public Vino(string nombre, int cantidad, int cantCopas, int año) base : (nombre, cantidad)
        {
            this.cantCopas = cantCopas;
            this.año = año;
        }
        public Vino()
        {
            this.cantCopas = 0;
            this.año = 0;
        }

       

        public static int MostrarLimitePermitidoDeVasos()
    }
}
