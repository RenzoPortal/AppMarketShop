using System;
using System.Collections.Generic;
using System.Text;

namespace AppMarketShop.Models
{
    public class Product
    {
        //Atributos de la clase
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}
