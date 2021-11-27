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
        private string imagetxt;
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
        public string ImageTxt
        {
            get => imagetxt;
            set
            {
                if (imagetxt != value)
                {
                    imagetxt = value;
                }
                OnPropertyChanged();
            }
        }

        private void AddCategory()
        {
            var name = NameTxt;
            var img = ImageTxt;

            DataLogic dl = new DataLogic();
            bool success = dl.AddCategory(name, img);
            if (success)
            {
                NameTxt = string.Empty;
                ImageTxt = string.Empty;
                App.Current.MainPage.DisplayAlert("Success", "The category was added", "Ok");
            }
        }
    }
}
