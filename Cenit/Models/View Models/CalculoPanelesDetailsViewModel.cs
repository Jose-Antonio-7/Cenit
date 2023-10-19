using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenit.Models.View_Models
{
    public partial class CalculoPanelesDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        public CalculoPaneles calculo;
    }
}
