
using Cenit.Models;
using System.Collections.ObjectModel;

namespace Cenit
{
    public partial class App : Application
    {
        public static CalculoPanelesListViewModel calculos;

        public App()
        {
            InitializeComponent();
            calculos = new CalculoPanelesListViewModel();

            MainPage = new TabbedMenu();
            Current.UserAppTheme = AppTheme.Light;

            //calculos = new CalculoPanelesListViewModel();

        }
    }
}