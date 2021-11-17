using AppMarketShop.Views;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class CheckoutViewModel : BaseViewModel
    {
        public Command _BackCommand;
        public Command _PaymentCommand;
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
        public ICommand PaymentCommand
        {
            get
            {
                if (_PaymentCommand == null)
                {
                    _PaymentCommand = new Command(PaymentPopupPage);
                }
                return _PaymentCommand;
            }
        }
        private void BackToPage(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new CartPage());
        }
        //Metodo
        private void PaymentPopupPage(object obj)
        {
            App.Current.MainPage.Navigation.PushPopupAsync(new PopupPaymentPage());
        }
    }
}
