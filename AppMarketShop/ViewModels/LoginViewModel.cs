using AppMarketShop.Data;
using AppMarketShop.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        //Comandos para llevarnos al AppShell y RegisterPage
        public Command _RegisterCommand;
        public Command _LoginCommand;
        private string emailtxt;
        private string passwordtxt;
        public ICommand LoginCommand
        {
            get
            {
                if (_LoginCommand == null)
                {
                    _LoginCommand = new Command(LoginUser);
                }
                return _LoginCommand;
            }
        }
        public ICommand RegisterCommand
        {
            get
            {
                if (_RegisterCommand == null)
                {
                    _RegisterCommand = new Command(RegisterPage);
                }
                return _RegisterCommand;
            }
        }
        private void LoginUser()
        {
            var email = EmailTxt;
            var pass = PasswordTxt;

            DataLogic dl = new DataLogic();
            Models.User success = dl.LoginUser(email, pass);
            if (success.Id != 0)
            {
                Preferences.Set("Email", success.Email);
                Preferences.Set("FullName", success.FullName);
                var ema = Preferences.Get("Email", "");
                var fname = Preferences.Get("FullName", "");
                App.Current.MainPage = new AppShell();
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Error", "User not found", "Ok");
            }
        }
        private void RegisterPage(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }
        public string EmailTxt
        {
            get => emailtxt;
            set
            {
                if (emailtxt != value)
                {
                    emailtxt = value;
                }
                OnPropertyChanged();
            }
        }
        public string PasswordTxt
        {
            get => passwordtxt;
            set
            {
                if (passwordtxt != value)
                {
                    passwordtxt = value;
                }
                OnPropertyChanged();
            }
        }
    }
}
