using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMarketShop.Models
{
    public class Order
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [ForeignKey(typeof(User))]
        public int UserId { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        [MaxLength(20)]
        public string City { get; set; }
        [MaxLength(20)]
        public string Province { get; set; }
        [MaxLength(10)]
        public string Phone { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
    }
}
