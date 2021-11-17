using AppMarketShop.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        public Command _AddCateCommand;
        private string nametxt;
        public ICommand AddCateCommand
        {
            get
            {
                if (_AddCateCommand == null)
                {
                    _AddCateCommand = new Command(AddCategory);
                }
                return _AddCateCommand;
            }
        }
        public string NameTxt
        {
            get => nametxt;
            set
            {
                if (nametxt != value)
                {
                    nametxt = value;
                }
                OnPropertyChanged();
            }
        }
        private void AddCategory()
        {
            var name = NameTxt;

            DataLogic dl = new DataLogic();
            bool success = dl.AddCategory(name);
            if (success)
            {
                NameTxt = string.Empty;
                App.Current.MainPage.DisplayAlert("Success", "The category was added", "Ok");
            }
        }
    }
}
