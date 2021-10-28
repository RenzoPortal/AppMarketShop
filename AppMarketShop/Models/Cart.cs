using System;
using System.Collections.Generic;
using System.Text;

namespace AppMarketShop.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime DataCreate { get; set; }
    }
}
