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
    public class HomeViewModel : BaseViewModel
    {
        //Comandos para llevarnos SearchPage y otro a Detalles de un producto
        public Command _SeeMoreCommand;
        public Command _CartCommand;
        public ICommand SeeMoreCommand
        {
            get
            {
                if (_SeeMoreCommand == null)
                {
                    _SeeMoreCommand = new Command(SearhPage);
                }
                return _SeeMoreCommand;
            }
        }
        public ICommand CartCommand
        {
            get
            {
                if (_CartCommand == null)
                {
                    _CartCommand = new Command(CartToPage);
                }
                return _CartCommand;
            }
        }
        public HomeViewModel()
        {
            //Mostrando CollectionsViews
            ListarCategory();
            ListarProduct();
        }

        //Usando los Category
        ObservableCollection<Category> Categories = new ObservableCollection<Category>();
        public ObservableCollection<Category> GetCategories
        {
            get { return Categories; }
            set
            {
                Categories = value;
                OnPropertyChanged();
            }
        }
        private void ListarCategory()
        {
            DataLogic dataLogic = new DataLogic();
            var lstCategories = dataLogic.ShowDataCategory();
            foreach (var cateDetails in lstCategories)
            {
                Category category = new Category
                {
                    Id = cateDetails.Id,
                    Name = cateDetails.Name,
                    Image = cateDetails.Image
                };
                GetCategories.Add(category);
            }
        }

        public bool AddToCart(int id, string image, string nombre, float precio, float total, int cantidad)
        {
            DataTemporal tabla = new DataTemporal();
            tabla.IdProduct = id;
            tabla.Image = image;
            tabla.Nombre = nombre;
            tabla.Precio = precio;
            tabla.Total = total;
            tabla.Cantidad = cantidad;
            DataLogic dataLogic = new DataLogic();
            bool success = dataLogic.AddToCart(tabla);
            return success;
        }

        //Usando los Product
        ObservableCollection<Product> Products = new ObservableCollection<Product>();
        public ObservableCollection<Product> GetProducts
        {
            get{ return Products; }
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
        ObservableCollection<Product> ProductsCate = new ObservableCollection<Product>();
        public ObservableCollection<Product> GetProductsCategory
        {
            get { return ProductsCate; }
            set
            {
                ProductsCate = value;
                OnPropertyChanged();
            }
        }
        public void ListProdCategory(int id)
        {
            DataLogic dataLogic = new DataLogic();
            var lstProducts = dataLogic.ListProdCategory(id);
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
                GetProductsCategory.Add(product);
            }
        }
        //Metodo de SeeMoreCommand
        private void SearhPage(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new SearchPage());
        }
        private void CartToPage(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new CartPage());
        }
    }
}
