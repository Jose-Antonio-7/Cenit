using Cenit.Models;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace Cenit;

public partial class ColeccionCalculos : ContentPage
{
    //ObservableCollection<CalculoPaneles>  calculos;

    public ColeccionCalculos()
	{
		InitializeComponent();
        //BindingContext = App.calculos.ListaCalculos;
        IniciarLista();

        CollectionViewCalculos.ItemsSource = App.calculos.ListaCalculos;


		//ToDo: agregar bindeo para que se puedan estar agregando calculos
	}

    private void IniciarLista() 
	{
        App.calculos.ListaCalculos = new ObservableCollection<CalculoPaneles>
        {
			new CalculoPaneles { ConsumoElectrico = 3034, DuracionHoraSolarPico = 5.54, VoltajePanel = 500, FactorPerdida = 1.3, CantidadPaneles = 24},
            new CalculoPaneles { ConsumoElectrico = 2022, DuracionHoraSolarPico = 5.1, VoltajePanel = 250, FactorPerdida = 1.3, CantidadPaneles = 10},
            new CalculoPaneles { ConsumoElectrico = 5007, DuracionHoraSolarPico = 5.1, VoltajePanel = 250, FactorPerdida = 1.3, CantidadPaneles = 48}
        };
		//CollectionViewCalculos.ItemsSource = App.calculos.ListaCalculos;
	}

}