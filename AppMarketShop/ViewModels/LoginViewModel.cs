using AppMarketShop.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        //Comandos para llevarnos al AppShell y RegisterPage
        public Command RegisterCommand { get; set; }
        public Command LoginCommand { get; set; }

        private string emailtxt;
        private string passwordtxt;
        public LoginViewModel()
        {
            //Usando los comamdo
            RegisterCommand = new Command(gotoRegisterPage);
            LoginCommand = new Command(gotoHomePage);
        }
        //Metodo de LoginCommand
        private void gotoHomePage(object obj)
        {
            if (EmailTxt.ToString()== "renzoportal34@gmail.com" & PasswordTxt.ToString()=="123456")
            {
                Application.Current.MainPage = new AppShell();
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "Please enter a valid Email and Password !!", "Ok");
            }
        }
        //Metodo de RegisterCommand
        private void gotoRegisterPage(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new RegisterPage());
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
