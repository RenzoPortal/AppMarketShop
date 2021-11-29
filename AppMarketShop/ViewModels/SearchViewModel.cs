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
        public string _Filter;
        //Comandos para llevarnos SingleItemPage
        public Command _BackCommand;
        public Command _SearchCommand;
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
        public ICommand SearchCommand
        {
            get
            {
                if (_SearchCommand == null)
                {
                    _SearchCommand = new Command(ShowDataProductFilter);
                }
                return _SearchCommand;
            }
        }
        public string Filter
        {
            get { return _Filter; }
            set
            {
                _Filter = value;
                ShowDataProductFilter();
                OnPropertyChanged();
            }
        }
        public SearchViewModel()
        {
            if (string.IsNullOrEmpty(Filter))
            {
                ListarProduct();
            }
            else
            {
                ShowDataProductFilter();
            }
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
        private void ShowDataProductFilter()
        {
            GetProducts.Clear();
            DataLogic dataLogic = new DataLogic();
            var lstProducts = dataLogic.ShowDataProductFilter(Filter);
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
