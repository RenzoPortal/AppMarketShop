using AppMarketShop.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public Command _BackCommand;
        public Command _SignOutCommand;
        public Command _OrderHistoryCommand;
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
        public ICommand OrderHistoryCommand
        {
            get
            {
                if (_OrderHistoryCommand == null)
                {
                    _OrderHistoryCommand = new Command(OrderHistoryPage);
                }
                return _OrderHistoryCommand;
            }
        }
        private void BackToPage(object obj)
        {
            App.Current.MainPage = new AppShell();
        }
        private void SignOutPage(object obj)
        {
            Preferences.Remove("Email");
            App.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }
        private void OrderHistoryPage(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new OrdersPage());
        }
    }
}
