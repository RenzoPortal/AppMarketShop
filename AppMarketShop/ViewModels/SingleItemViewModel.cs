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
        public Command AddToCartCommand { get; set; }
        public SingleItemViewModel()
        {
            //Mostrando CollectionsViews
            productcolors = GetProductColor();
            //Usando los comamdo
            AddToCartCommand = new Command(gotoCartPage);
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
        private void gotoCartPage(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new CartPage());
        }
    }
}
