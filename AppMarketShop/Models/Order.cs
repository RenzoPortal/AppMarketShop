using System;
using System.Collections.Generic;
using System.Text;

namespace AppMarketShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Phone { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
    }
}
