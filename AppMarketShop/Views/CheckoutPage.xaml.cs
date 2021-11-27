using AppMarketShop.ViewModels;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
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
            BindingContext = new CheckoutViewModel();
            int id = Preferences.Get("IdUser", 0);
            nametxt.Text = Preferences.Get("FullName", "");
            correotxt.Text = Preferences.Get("Email", "");
        }
    }
}