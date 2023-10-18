using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenit.Models
{
    class CalculoPaneles
    {
        public int ConsumoElectrico { get; set; }
        public double DuracionHoraSolarPico { get; set; }
        public int VoltajePanel { get; set; }
        public double FactorPerdida { get; set; } = 1.3;
        public int CantidadPaneles { get; set; }

    }
}
