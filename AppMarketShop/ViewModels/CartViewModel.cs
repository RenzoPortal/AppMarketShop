using AppMarketShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppMarketShop.ViewModels
{
    //Metodo de la clase
    public class CartViewModel
    {
        //Usando el modelo Products
        public ObservableCollection<Products> cartproducts { get; set; }
        //Contructor de la clase
        public CartViewModel()
        {
            //Insertando datos a Products para muestra
            cartproducts = new ObservableCollection<Products>
            {
                new Products{ Image="SearchiPad.png", Name="2020 Apple iPad Air 10.9", Price ="579" },
                new Products{ Image="AirPods.png", Name="APPLE AirPods Pro - White", Price ="375" },
            };
        }
    }
}
