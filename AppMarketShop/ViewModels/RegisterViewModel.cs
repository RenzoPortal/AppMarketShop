using AppMarketShop.Data;
using AppMarketShop.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        //Comandos para Regresar Atras y otro para llevarnos AppShell
        public Command _BackCommand;
        public Command _RegisterCommand;
        private string emailtxt;
        private string passwordtxt;
        private string conpasswordtxt;
        public ICommand RegisterCommand
        {
            get
            {
                if (_RegisterCommand == null)
                {
                    _RegisterCommand = new Command(RegisterUser);
                }
                return _RegisterCommand;
            }
        }
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
        public string ConPasswordTxt
        {
            get => conpasswordtxt;
            set
            {
                if (conpasswordtxt != value)
                {
                    conpasswordtxt = value;
                }
                OnPropertyChanged();
            }
        }
        private void RegisterUser()
        {
            var email = EmailTxt;
            var pass = PasswordTxt;
            var conpass = ConPasswordTxt;
            DataLogic dl = new DataLogic();
            bool success = dl.RegisterUser(email, pass);
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(conpass))
            {
                App.Current.MainPage.DisplayAlert("Error", "You must fill all the fields !!", "Ok");
            }
            else if (!string.Equals(pass, conpass))
            {
                App.Current.MainPage.DisplayAlert("Error", "Enter Same Password !!", "Ok");
            }
            else
            {
                if (success)
                {
                    EmailTxt = string.Empty;
                    PasswordTxt = string.Empty;
                    ConPasswordTxt = string.Empty;
                    App.Current.MainPage.Navigation.PushAsync(new LoginPage());
                }
            }
        }
        private void BackToPage(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }
    }
}
