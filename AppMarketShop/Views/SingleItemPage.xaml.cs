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
    public partial class SingleItemPage : ContentPage
    {
        public SingleItemPage(string id, string nombre, string imagen, string descrip, string precio)
        {
            InitializeComponent();
            //Instanciando la clase SingleItemViewModel
            BindingContext = new SingleItemViewModel();

            txtimage.Source = imagen;
            txtnombre.Text = nombre;
            txtdescripcion.Text = descrip;
            txtprecio.Text = precio;
            
        }
    }
}