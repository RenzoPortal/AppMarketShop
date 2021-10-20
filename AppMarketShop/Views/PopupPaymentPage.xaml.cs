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
    //Rg.Plugins.Popup para el diseño de nuestra ventana
    public partial class PopupPaymentPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        public PopupPaymentPage()
        {
            InitializeComponent();
        }
    }
}