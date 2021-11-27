using AppMarketShop.ViewModels;
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
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = new ProfileViewModel();
            int id = Preferences.Get("IdUser", 0);
            txtfullname.Text = Preferences.Get("FullName", "");
            txtemailuser.Text = Preferences.Get("Email", "");
        }
    }
}