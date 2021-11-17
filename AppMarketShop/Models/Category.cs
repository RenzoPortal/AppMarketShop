using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMarketShop.Models
{
    public class Category
    {
        //Atributos de la clase
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Product> Products { get; set; }
    }
}
