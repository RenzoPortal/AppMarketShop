using AppMarketShop.Models;
using AppMarketShop.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class SingleItemViewModel : BaseViewModel
    {
        //Comandos para llevarnos CartPage
        public Command _AddToCartCommand;
        public Command _BackCommand;
        public ICommand AddToCartCommand
        {
            get
            {
                if (_AddToCartCommand == null)
                {
                    _AddToCartCommand = new Command(CartPage);
                }
                return _AddToCartCommand;
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
        public SingleItemViewModel()
        {
            //Mostrando CollectionsViews
            productcolors = GetProductColor();
        }
        //Usando los ProdColor
        ObservableCollection<ProdColor> productcolors;
        public ObservableCollection<ProdColor> productColor
        {
            get { return productcolors; }
            set
            {
                productcolors = value;
                OnPropertyChanged();
            }
        }
        //Insertado datos a ProdColor
        private ObservableCollection<ProdColor> GetProductColor()
        {
            return new ObservableCollection<ProdColor>
            {
                new ProdColor{ Name="Sky Blue", ColorOption = ColorConverters.FromHex("#7485C1") },
                new ProdColor{ Name="Rose Gold", ColorOption = ColorConverters.FromHex("#C9A19C") }
            };
        }
        //Metodo de AddToCartCommand
        private void CartPage(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new CartPage());
        }
        private void BackToPage(object obj)
        {
            App.Current.MainPage = new AppShell();
        }
    }
}
