using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics.Text;

namespace Cenit
{
    public partial class CalculadoraSimple : ContentPage
    {

        public CalculadoraSimple()
        {
            InitializeComponent();
            //Aplication.Curretn
        }

        private void CalcularPaneles(object sender, EventArgs e)
        {
            //ToDo: Validacion de valores
            var consumo = Int32.Parse(Consumo.Text.Trim());
            var hsp = double.Parse(HSP.Text.Trim());
            var voltaje = Int32.Parse(VoltajePanel.Text.Trim());
            var factorPerdida = 1.3;

            var consumoDiario = ((consumo * 1000) / 60) * factorPerdida;

            var produccionXPanel = hsp * voltaje;

            var paneles = Math.Ceiling(consumoDiario / produccionXPanel);

            //ToDo: Agregar campo precio de panales
            //ToDo: Que el factor perdida pueda modificarse pero inicie con valor de 1.3
            //ToDo: Campo de nombre de cliente o proyecto

            Resultado.Text = $"{paneles} Paneles solares de {voltaje} Wats";
        }
    }
}