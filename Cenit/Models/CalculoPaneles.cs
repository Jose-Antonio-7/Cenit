using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenit.Models
{
    public class CalculoPaneles
    {
        //public int Id { get; set; }
        //public string NombreCliente { get; set; }

        public int ConsumoElectrico { get; set; }
        public double DuracionHoraSolarPico { get; set; }
        public int VoltajePanel { get; set; }
        public double FactorPerdida { get; set; } = 1.3;
        public int CantidadPaneles { get; set; }

        //public string NombreInversor { get; set; }
        //public int CantidadInversor { get; set; }

        //public string NombreCajasProteccion { get; set; }
        //public int CantidadCajasProteccion { get; set; }





    }
}
