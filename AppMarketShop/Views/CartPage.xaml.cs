using AppMarketShop.Data;
using AppMarketShop.Models;
using AppMarketShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMarketShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        OrderDetail orderDetail;
        public CartPage()
        {
            InitializeComponent();
            BindingContext = new CartViewModel();
        }
        private void AddOrder_Clicked(object sender, EventArgs e)
        {
            List<OrderDetail> listorderdet = new List<OrderDetail>();
            DataLogic dataLogic = new DataLogic();
            var ls = dataLogic.ShowDataTemporal();
            foreach (var prodetails in ls)
            {
                orderDetail = new OrderDetail
                {
                    Description = prodetails.Nombre,
                    Price = prodetails.Precio,
                    Total = prodetails.Total,
                    Quantity = prodetails.Cantidad,
                    ProductId = prodetails.IdProduct
                };
                listorderdet.Add(orderDetail);
            }
            float total = Convert.ToSingle(txttotal.Text);
            dataLogic.RegisterPedido(listorderdet, total);
            dataLogic.DeleteAllCart();
            Navigation.PushModalAsync(new CheckoutPage());
        }
    }
}