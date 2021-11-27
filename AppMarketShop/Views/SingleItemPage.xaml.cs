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

            txtid.Text = id;
            txtimage.Source = imagen;
            txtnombre.Text = nombre;
            txtdescripcion.Text = descrip;
            txtprecio.Text = precio;
            
        }

        private void AddToCart_Clicked(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            string nombre = txtnombre.Text;
            string image = txtimage.Source.ToString();
            float precio = Convert.ToSingle(txtprecio.Text);
            string descrip = txtdescripcion.Text;
            int cantidad = Convert.ToInt32(txtcantidad.Text);
            float total = cantidad * precio;
            HomeViewModel pedido = new HomeViewModel();
            bool success = pedido.AddToCart(id, image, nombre, precio, total, cantidad);
            if (success)
            {
                DisplayAlert("Success", "Se agrego al carrito", "Ok");
            }
            else
            {
                DisplayAlert("Error", "No se pudo agrego al carrito", "Ok");
            }
        }
    }
}