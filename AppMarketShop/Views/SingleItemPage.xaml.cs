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
    public partial class SingleItemPage : ContentPage
    {
        public SingleItemPage()
        {
            InitializeComponent();
            //Instanciando la clase SingleItemViewModel
            BindingContext = new ViewModels.SingleItemViewModel();
        }
    }
}