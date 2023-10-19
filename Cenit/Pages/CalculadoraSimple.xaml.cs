using Cenit.Models;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics.Text;

namespace Cenit
{
    public partial class CalculadoraSimple : ContentPage
    {

        public CalculadoraSimple()
        {
            InitializeComponent();
            //BindingContext = App.calculos;
            //Aplication.Curretn
        }

        private void CalcularPaneles(object sender, EventArgs e)
        {
            //ToDo: Validacion de valores

            CalculoPaneles calculo = new CalculoPaneles { 
                ConsumoElectrico = Int32.Parse(Consumo.Text.Trim()), 
                DuracionHoraSolarPico = double.Parse(HSP.Text.Trim()), 
                VoltajePanel = Int32.Parse(VoltajePanel.Text.Trim())
            };

            var consumoDiario = ((calculo.ConsumoElectrico * 1000) / 60) * calculo.FactorPerdida;

            var produccionXPanel = calculo.DuracionHoraSolarPico * calculo.VoltajePanel;

            calculo.CantidadPaneles = (int)Math.Ceiling(consumoDiario / produccionXPanel);

            //ToDo: Agregar campo precio de panales
            //ToDo: Que el factor perdida pueda modificarse pero inicie con valor de 1.3
            //ToDo: Campo de nombre de cliente o proyecto

            Resultado.Text = $"{calculo.CantidadPaneles} Paneles solares de {calculo.VoltajePanel} Wats";
            App.calculos.ListaCalculos.Add(calculo);
        }
    }
}