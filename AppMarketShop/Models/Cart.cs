using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMarketShop.Models
{
    public class Cart
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(Product))]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime DataCreate { get; set; }
    }
}
