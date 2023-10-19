using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenit.Models
{
    public partial class CalculoPanelesListViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<CalculoPaneles> listaCalculos = new();

        [ObservableProperty]
        private CalculoPaneles calculo = new();

        [RelayCommand]
        private void Add()
        {
            ListaCalculos.Add(calculo);
            Calculo = new();
        }
    }
}
