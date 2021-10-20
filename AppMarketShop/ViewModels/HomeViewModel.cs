using AppMarketShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppMarketShop.ViewModels
{
    //Metodo de la clase
    public class HomeViewModel
    {
        //Usando los modelos Categories y Products
        public ObservableCollection<Categories> categories { get; set; }
        public ObservableCollection<Products> products { get; set; }

        //Contructor de la clase
        public HomeViewModel()
        {
            //Insertando datos a Categories
            categories = new ObservableCollection<Categories>
            {
                new Categories{ Name="Wearable" },
                new Categories{ Name="Laptops" },
                new Categories{ Name="Phones" },
                new Categories{ Name="Airphones" }
            };
            //Insertando datos a Products
            products = new ObservableCollection<Products>
            {
                new Products{ Image="AppleWatch.png", Name="AppleWatch", Description ="Falta llenar", Color ="Black and Red", Price ="120" },
                new Products{ Image="AppleWatch.png", Name="AppleWatch", Description ="Falta llenar", Color ="Black and Red", Price ="120" },
                new Products{ Image="AppleWatch.png", Name="AppleWatch", Description ="Falta llenar", Color ="Black and Red", Price ="120" }
            };
        }
    }
}
