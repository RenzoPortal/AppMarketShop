using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMarketShop.Models
{
    public class Product
    {
        //Atributos de la clase
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Image { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [ForeignKey(typeof(Category))]
        public int CategoryId { get; set; }
        [ManyToOne]
        public Category Category { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public float Price { get; set; }
    }
}
