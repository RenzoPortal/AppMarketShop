using AppMarketShop.Views;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class CheckoutViewModel : BaseViewModel
    {
        //Comandos para mostrarnos un ventana PopupPaymentPage
        public Command PaymentCommand { get; set; }
        public CheckoutViewModel()
        {
            //Usando los comamdo
            PaymentCommand = new Command(gotoPaymentPage);
        }
        //Metodo de PaymentCommand
        private void gotoPaymentPage(object obj)
        {
            Application.Current.MainPage.Navigation.PushPopupAsync(new PopupPaymentPage());
        }
    }
}
