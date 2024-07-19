using P6TravelsAPP_CristoferM.Views;

namespace P6TravelsAPP_CristoferM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
