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
    public class HomeViewModel : BaseViewModel
    {
        //Comandos para llevarnos SearchPage y otro a Detalles de un producto
        public Command SeeMoreCommand { get; set; }
        public Command SelectionCommand { get; set; }
        public HomeViewModel()
        {
            //Mostrando CollectionsViews
            categories = GetCategories();
            products = GetProducts();
            //Usando los comamdo
            SeeMoreCommand = new Command(gotoSearhPage);
            SelectionCommand = new Command(gotoSingleItemPage);
        }
        //Usando los Category
        ObservableCollection<Category> categories;
        public ObservableCollection<Category> Category
        {
            get { return categories; }
            set
            {
                categories = value;
                OnPropertyChanged();
            }
        }
        //Insertado datos a Category
        private ObservableCollection<Category> GetCategories()
        {
            return new ObservableCollection<Category>
            {
                new Category{ Name="Wearable" },
                new Category{ Name="Laptops" },
                new Category{ Name="Phones" },
                new Category{ Name="Airphones" }
            };
        }
        //Usando los Product
        ObservableCollection<Product> products;
        public ObservableCollection<Product> Product
        {
            get { return products; }
            set
            {
                products = value;
                OnPropertyChanged();
            }
        }
        //Insertado datos a Product
        private ObservableCollection<Product> GetProducts()
        {
            return new ObservableCollection<Product>
            {
                 new Product{ Image="AppleWatch.png", Name="AppleWatch", Description ="Falta llenar", Price =120 },
                new Product{ Image="AppleWatch.png", Name="AppleWatch", Description ="Falta llenar", Price =120 },
                new Product{ Image="AppleWatch.png", Name="AppleWatch", Description ="Falta llenar", Price =120 }
            };
        }
        //Metodo de SeeMoreCommand
        private void gotoSearhPage(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new SearchPage());
        }
        //Metodo de SelectionCommand
        private void gotoSingleItemPage(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new SingleItemPage());
        }
    }
}
