using AppMarketShop.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppMarketShop.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public Command _AddProdCommand;
        private string imagetxt;
        private string nametxt;
        private string categoryIdtxt;
        private string descríptiontxt;
        private string pricetxt;
        public ICommand AddProdCommand
        {
            get
            {
                if (_AddProdCommand == null)
                {
                    _AddProdCommand = new Command(AddProduct);
                }
                return _AddProdCommand;
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
        public string CategoryIdTxt
        {
            get => categoryIdtxt;
            set
            {
                if (categoryIdtxt != value)
                {
                    categoryIdtxt = value;
                }
                OnPropertyChanged();
            }
        }
        public string DescriptionTxt
        {
            get => descríptiontxt;
            set
            {
                if (descríptiontxt != value)
                {
                    descríptiontxt = value;
                }
                OnPropertyChanged();
            }
        }
        public string PriceTxt
        {
            get => pricetxt;
            set
            {
                if (pricetxt != value)
                {
                    pricetxt = value;
                }
                OnPropertyChanged();
            }
        }
        private void AddProduct()
        {
            var image = ImageTxt;
            var name = NameTxt;
            var id = Convert.ToInt32(CategoryIdTxt);
            var descrip = DescriptionTxt;
            var price = Convert.ToSingle(PriceTxt);

            DataLogic dl = new DataLogic();
            bool success = dl.AddProduct(image, name, id, descrip, price);
            if (success)
            {
                ImageTxt = string.Empty;
                NameTxt = string.Empty;
                DescriptionTxt = string.Empty;
                CategoryIdTxt = string.Empty;
                PriceTxt = string.Empty;
                App.Current.MainPage.DisplayAlert("Success", "The product was added", "Ok");
            }
        }
    }
}
