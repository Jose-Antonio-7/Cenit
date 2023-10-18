using Cenit.Models;

namespace Cenit;

public partial class ColeccionCalculos : ContentPage
{
	public ColeccionCalculos()
	{
		InitializeComponent();
		List<CalculoPaneles> ListaCalculosPaneles = new List<CalculoPaneles>();

		collectionView.ItemsSource = GetCalculos();
		//ToDo: agregar bindeo para que se puedan estar agregando calculos
		//      collectionView.SetBinding(ItemsView.ItemsSourceProperty, "ListaCalculosPaneles");

		//ListaCalculosPaneles.AddRange(GetCalculos());

	}

    private List<CalculoPaneles> GetCalculos() 
	{ 
		return new List<CalculoPaneles> 
		{
			new CalculoPaneles { ConsumoElectrico = 3034, DuracionHoraSolarPico = 5.54, VoltajePanel = 500, FactorPerdida = 1.3, CantidadPaneles = 24},
            new CalculoPaneles { ConsumoElectrico = 2022, DuracionHoraSolarPico = 5.1, VoltajePanel = 250, FactorPerdida = 1.3, CantidadPaneles = 10},
            new CalculoPaneles { ConsumoElectrico = 5007, DuracionHoraSolarPico = 5.1, VoltajePanel = 250, FactorPerdida = 1.3, CantidadPaneles = 48}


        };
	}
}