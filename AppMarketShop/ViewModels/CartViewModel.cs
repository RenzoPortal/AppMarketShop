using AppMarketShop.Models;
using AppMarketShop.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class CartViewModel : BaseViewModel
    {
        //Comandos para llevarnos CheckoutPage 
        public Command CheckOutCommand { get; set; }
        public CartViewModel()
        {
            //Mostrando CollectionsViews
            prodCarts = GetProdCart();
            //Usando los comamdo
            CheckOutCommand = new Command(gotoCheckoutPage);
        }
        //Usando los Product
        ObservableCollection<Product> prodCarts;
        public ObservableCollection< Product> prodCart
        {
            get { return prodCarts; }
            set
            {
                prodCarts = value;
                OnPropertyChanged();
            }
        }
        //Insertado datos a Product
        private ObservableCollection<Product> GetProdCart()
        {
            return new ObservableCollection<Product>
            {
                new Product{ Image="SearchiPad.png", Name="2020 Apple iPad Air 10.9", Price =579 },
                new Product{ Image="AirPods.png", Name="APPLE AirPods Pro - White", Price =375 },
            };
        }
        //Metodo de CheckOutCommand
        private void gotoCheckoutPage(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new CheckoutPage());
        }
    }
}
