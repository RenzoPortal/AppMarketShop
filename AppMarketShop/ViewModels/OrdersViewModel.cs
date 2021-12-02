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
    public class OrdersViewModel : BaseViewModel
    {
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
        private void BackToPage(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new ProfilePage());
        }
        public OrdersViewModel()
        {
            ShowDataOrders();
        }
        //Usando los Orders
        ObservableCollection<Orders> orders = new ObservableCollection<Orders>();
        public ObservableCollection<Orders> GetOrders
        {
            get { return orders; }
            set
            {
                orders = value;
                OnPropertyChanged();
            }
        }
        private void ShowDataOrders()
        {
            DataLogic dataLogic = new DataLogic();
            var lstOrders = dataLogic.ShowDataOrders();
            foreach (var orderDetails in lstOrders)
            {
                Orders order = new Orders
                {
                    Id = orderDetails.Id,
                    UserId = orderDetails.UserId,
                    Name = orderDetails.Name,
                    Email = orderDetails.Email,
                    Total = orderDetails.Total
                };
                GetOrders.Add(order);
            }
        }
    }
}
