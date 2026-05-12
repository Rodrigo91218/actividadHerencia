using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadHerencia
{
    public class AguaSaborizada:Bebida
    {
        private int cantVasos;
        private string sabor;

        public AguaSaborizada(string nombre, int cant, int cantVasos, string sabor) : base (nombre, cant) 
        {
            this.cantVasos = cantVasos;
            this.sabor = sabor;
        }
        public AguaSaborizada()
        {
            this.cantVasos = 0;
            this.sabor = "";
        }

        public int CantVasos { get => cantVasos; set => cantVasos = value; }
        public string Sabor { get => sabor; set => sabor = value; }
    }
}
