using AppMarketShop.Data;
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
    public class SearchViewModel : BaseViewModel
    {
        //Comandos para llevarnos SingleItemPage
        public Command _BackCommand;
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
        public SearchViewModel()
        {
            //Mostrando CollectionsViews
            ListarProduct();
        }
        ObservableCollection<Product> Products = new ObservableCollection<Product>();
        public ObservableCollection<Product> GetProducts
        {
            get { return Products; }
            set
            {
                Products = value;
                OnPropertyChanged();
            }
        }
        private void ListarProduct()
        {
            DataLogic dataLogic = new DataLogic();
            var lstProducts = dataLogic.ShowDataProduct();
            foreach (var prodDetails in lstProducts)
            {
                Product product = new Product
                {
                    Id = prodDetails.Id,
                    Image = prodDetails.Image,
                    Name = prodDetails.Name,
                    Description = prodDetails.Description,
                    Price = prodDetails.Price
                };
                GetProducts.Add(product);
            }
        }
        //Metodo de SelectionCommand
        private void BackToPage(object obj)
        {
            App.Current.MainPage = new AppShell();
        }
    }
}
