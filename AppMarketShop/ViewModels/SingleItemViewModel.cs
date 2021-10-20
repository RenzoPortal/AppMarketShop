using AppMarketShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Essentials;

namespace AppMarketShop.ViewModels
{
    //Metodo de la clase
    public class SingleItemViewModel
    {
        //Usando el modelo ProductColor
        public ObservableCollection<ProductColor> productcolors { get; set; }
        //Contructor de la clase
        public SingleItemViewModel()
        {
            //Insertando datos a ProductColor
            productcolors = new ObservableCollection<ProductColor>
            {
                new ProductColor{ Name="Sky Blue", ColorOption = ColorConverters.FromHex("#7485C1") },
                new ProductColor{ Name="Rose Gold", ColorOption = ColorConverters.FromHex("#C9A19C") }
            };
        }
    }
}
