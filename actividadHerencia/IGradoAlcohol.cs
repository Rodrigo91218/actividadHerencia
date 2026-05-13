using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadHerencia
{
    internal interface IGradoAlcohol
    {
        double PorcentajeAlcohol { get; set; }

        void MostrarLimitePermitidoDeVasos();

        bool EsBebidaAlcoholica();
    }
}
