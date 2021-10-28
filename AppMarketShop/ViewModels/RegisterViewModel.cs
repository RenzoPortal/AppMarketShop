using AppMarketShop.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        //Comandos para Regresar Atras y otro para llevarnos AppShell
        public Command BackCommand { get; set; }
        public Command CreateUserCommand { get; set; }
        private string emailtxt;
        private string passwordtxt;
        private string conpasswordtxt;
        public RegisterViewModel()
        {
            //Usando los comamdo
            BackCommand = new Command(gotoBack);
            CreateUserCommand = new Command(gotoHomePage);
        }
        //Metodo de BackCommand
        private void gotoBack(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }
        //Metodo de CreateUserCommand
        private void gotoHomePage(object obj)
        {
            Application.Current.MainPage = new AppShell();
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
                if (passwordtxt != value)
                {
                    conpasswordtxt = value;
                }
                OnPropertyChanged();
            }
        }
    }
}
