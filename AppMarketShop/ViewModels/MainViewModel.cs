using AppMarketShop.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        //Comando para llevarnos al LoginPage
        public Command StartCommand { get; set; }
        public MainViewModel()
        {
            //Usando el comamdo
            StartCommand = new Command(gotoLoginPage);
        }
        //Metodo para ir al LoginPage
        private void gotoLoginPage(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }
    }
}
