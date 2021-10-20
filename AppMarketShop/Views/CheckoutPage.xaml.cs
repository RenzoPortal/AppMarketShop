using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMarketShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckoutPage : ContentPage
    {
        public CheckoutPage()
        {
            InitializeComponent();
        }
        //Metodo para mostrar un ventana Popup
        private void Button_Clicked(object sender, EventArgs e)
        {
             Navigation.PushPopupAsync(new PopupPaymentPage());
        }
    }
}