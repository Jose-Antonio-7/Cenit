
namespace Cenit
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new TabbedMenu();
            Current.UserAppTheme = AppTheme.Light;

        }
    }
}