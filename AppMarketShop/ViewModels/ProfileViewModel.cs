using AppMarketShop.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public Command _BackCommand;
        public Command _SignOutCommand;
        public ICommand BackCommand
        {
            get
            {
                if (_BackCommand == null)
                {
                    _BackCommand = new Command(BackToPage);
                }
                return _BackCommand;
            }
        }
        public ICommand SignOutCommand
        {
            get
            {
                if (_SignOutCommand == null)
                {
                    _SignOutCommand = new Command(SignOutPage);
                }
                return _SignOutCommand;
            }
        }
        private void BackToPage(object obj)
        {
            App.Current.MainPage = new AppShell();
        }
        private void SignOutPage(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }
    }
}
