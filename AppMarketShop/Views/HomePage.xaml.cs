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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            //Instanciando la clase HomeViewModel
            BindingContext = new HomeViewModel();
        }

        private void SelecProd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var c = e.CurrentSelection.First();
            Models.Product model = e.CurrentSelection.FirstOrDefault() as Models.Product;
            string id = model.Id.ToString();
            string nombre = model.Name;
            string imagen = model.Image;
            string descrip = model.Description;
            string precio = model.Price.ToString();
            Navigation.PushModalAsync(new SingleItemPage(id, nombre, imagen, descrip, precio));
        }
    }
}