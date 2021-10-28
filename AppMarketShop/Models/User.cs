using System;
using System.Collections.Generic;
using System.Text;

namespace AppMarketShop.Models
{
    public class User
    {
        //Atributos de la clase
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
    }
}
