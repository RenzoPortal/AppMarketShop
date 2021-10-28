using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AppMarketShop.Models
{
    public class ProdColor
    {
        //Atributos de la clase
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public Color ColorOption { get; set; }
    }
}
