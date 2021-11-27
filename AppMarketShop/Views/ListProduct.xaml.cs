using AppMarketShop.ViewModels;
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
    public partial class ListProduct : ContentPage
    {
        public ListProduct( int id, string name)
        {
            InitializeComponent();
            HomeViewModel prodcate = new HomeViewModel();
            prodcate.ListProdCategory(id);
            CollectionProductCate.ItemsSource = prodcate.GetProductsCategory;

            BindingContext = new CategoryViewModel();

            namecatetxt.Text = name;
        }
    }
}