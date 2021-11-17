using AppMarketShop.Models;
using AppMarketShop.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class CartViewModel : BaseViewModel
    {
        //Comandos para llevarnos CheckoutPage 
        public Command _CheckOutCommand;
        public Command _BackCommand;

        public ICommand CheckOutCommand
        {
            get
            {
                if (_CheckOutCommand == null)
                {
                    _CheckOutCommand = new Command(CheckoutPage);
                }
                return _CheckOutCommand;
            }
        }
        public ICommand BackCommand
        {
            get
            {
                if (_BackCommand == null)
                {
                    _BackCommand = new Command(BackToPage);
                }
                return _BackCommand;
            }
        }
        public CartViewModel()
        {
            //Mostrando CollectionsViews
            prodCarts = GetProdCart();
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
        //Metodos
        private void BackToPage(object obj)
        {
            App.Current.MainPage = new AppShell();
        }
        private void CheckoutPage(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new CheckoutPage());
        }
    }
}
