using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMarketShop.Models
{
    public class OrderDetail
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(Product))]
        public int ProductId { get; set; }
        [ForeignKey(typeof(Order))]
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
