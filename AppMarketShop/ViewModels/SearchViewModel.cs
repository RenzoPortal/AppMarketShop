using AppMarketShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppMarketShop.ViewModels
{
    //Metodo de la clase
    public class SearchViewModel
    {
        //Usando el modelo Products
        public ObservableCollection<Products> searchproducts { get; set; }
        //Contructor de la clase
        public SearchViewModel()
        {
            //Insertando datos a Products para muestra
            searchproducts = new ObservableCollection<Products>
            {
                new Products{ Image="SearchiPad.png", Name="Apple\niPad Air", Price ="579" },
                new Products{ Image="SearchApple.png", Name="Apple\nWatch", Price ="139" },
                new Products{ Image="SearchiPad.png", Name="Apple\niPad Air", Price ="579" },
                new Products{ Image="SearchApple.png", Name="Apple\nWatch", Price ="139" }
            };
        }
    }
}
