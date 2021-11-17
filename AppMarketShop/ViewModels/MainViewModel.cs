using AppMarketShop.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        //Comando para llevarnos al LoginPage
        public Command _StartCommand;
        public ICommand StartCommand
        {
            get
            {
                if (_StartCommand == null)
                {
                    _StartCommand = new Command(LoginPage);
                }
                return _StartCommand;
            }
        }
        //Metodo
        private void LoginPage(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }
    }
}
