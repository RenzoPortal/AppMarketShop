using System;
using System.Collections.Generic;
using System.Text;

namespace AppMarketShop.Models
{
    public class DataTemporal
    {
        public int IdProduct { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public float Total { get; set; }
        public int Cantidad { get; set; }
    }
}
