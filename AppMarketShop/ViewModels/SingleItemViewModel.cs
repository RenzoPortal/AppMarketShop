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
        public Command _BackCommand;
        public Command _IncrementCommand;
        public Command _DecrementCommand;

        private int _TotalQuanity;

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
        public ICommand DecrementCommand
        {
            get
            {
                if (_DecrementCommand == null)
                {
                    _DecrementCommand = new Command(DecrementOrder);
                }
                return _DecrementCommand;
            }
        }
        public ICommand IncrementCommand
        {
            get
            {
                if (_IncrementCommand == null)
                {
                    _IncrementCommand = new Command(IncrementOrder);
                }
                return _IncrementCommand;
            }
        }
        public int TotalQuanity
        {
            get
            {
                return _TotalQuanity;
            }
            set
            {
                _TotalQuanity = value;
                if (_TotalQuanity < 0)
                    _TotalQuanity = 0;
                if (_TotalQuanity > 10)
                    _TotalQuanity -= 1;
                OnPropertyChanged();
            }
        }
        public SingleItemViewModel()
        {
            TotalQuanity = 0;
            DecrementOrder();
            IncrementOrder();
        }
        private void BackToPage(object obj)
        {
            App.Current.MainPage = new AppShell();
        }
        private void DecrementOrder()
        {
            TotalQuanity--;
        }
        private void IncrementOrder()
        {
            TotalQuanity++;
        }
    }
}
