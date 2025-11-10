using System.Configuration;
using System.Data;
using System.Windows;

namespace BAT_Man
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Loginseite zum Start aufrufen
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            LoginPage loginPage = new LoginPage();
            bool? result = loginPage.ShowDialog();
        }
    }

}
