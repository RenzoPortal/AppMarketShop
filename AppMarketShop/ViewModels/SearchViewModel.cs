using AppMarketShop.Models;
using AppMarketShop.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class SearchViewModel : BaseViewModel
    {
        //Comandos para llevarnos SingleItemPage
        public Command SelectionCommand { get; set; }
        public SearchViewModel()
        {
            //Mostrando CollectionsViews
            searchproduct = GetProdSearch();
            //Usando los comamdo
            SelectionCommand = new Command(gotoSingleItemPage);
        }
        //Usando los Product
        ObservableCollection<Product> searchproduct;
        public ObservableCollection<Product> Searchproduct
        {
            get { return searchproduct; }
            set
            {
                searchproduct = value;
                OnPropertyChanged();
            }
        }
        //Insertado datos a Product
        private ObservableCollection<Product> GetProdSearch()
        {
            return new ObservableCollection<Product>
            {
                new Product{ Image="SearchiPad.png", Name="Apple\niPad Air", Price =579 },
                new Product{ Image="SearchApple.png", Name="Apple\nWatch", Price =139 },
                new Product{ Image="SearchiPad.png", Name="Apple\niPad Air", Price =579 },
                new Product{ Image="SearchApple.png", Name="Apple\nWatch", Price =139 }
            };
        }
        //Metodo de SelectionCommand
        private void gotoSingleItemPage(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new SingleItemPage());
        }
    }
}
