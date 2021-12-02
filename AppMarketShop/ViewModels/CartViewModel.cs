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
    public class CartViewModel : BaseViewModel
    {
        public float _total;
        public float total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
                OnPropertyChanged();
            }
        }
        //Comandos para llevarnos CheckoutPage 
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
        public CartViewModel()
        {
            //Mostrando CollectionsViews
            ShowDataTemporal();


        }
        //Usando los Product
        ObservableCollection<DataTemporal> dataTemporals = new ObservableCollection<DataTemporal>();
        public ObservableCollection<DataTemporal> GetDataTemporal
        {
            get { return dataTemporals; }
            set
            {
                dataTemporals = value;
                OnPropertyChanged();
            }
        }
        private void ShowDataTemporal()
        {
            DataLogic dataLogic = new DataLogic();
            var lstDataTenporal = dataLogic.ShowDataTemporal();
            foreach (var datatempDetails in lstDataTenporal)
            {
                DataTemporal datatemp = new DataTemporal
                {
                    IdProduct = datatempDetails.IdProduct,
                    Image = datatempDetails.Image,
                    Nombre = datatempDetails.Nombre,
                    Cantidad = datatempDetails.Cantidad,
                    Precio = datatempDetails.Precio,
                    Total = datatempDetails.Total

                };
                GetDataTemporal.Add(datatemp);
                total += datatempDetails.Total;
            }

        }
        //Metodos
        private void BackToPage(object obj)
        {
            App.Current.MainPage = new AppShell();
        }
    }
}
