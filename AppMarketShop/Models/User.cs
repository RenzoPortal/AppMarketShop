using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMarketShop.Models
{
    public class User
    {
        //Atributos de la clase
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100)]
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
