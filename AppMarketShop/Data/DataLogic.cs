using AppMarketShop.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AppMarketShop.Data
{
    public class DataLogic
    {
        private SQLiteConnection conn;
        private User user;
        private Category category;
        private Product product;
        private Cart cart;
        private Order order;
        private OrderDetail orderDetail;
        public DataLogic()
        {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<User>();
            conn.CreateTable<Category>();
            conn.CreateTable<Product>();
            conn.CreateTable<Cart>();
            conn.CreateTable<Order>();
            conn.CreateTable<OrderDetail>();
        }
        public bool RegisterUser(string email, string pass)
        {
            user = new User
            {
                Email = email,
                Password = pass
            };
            try
            {
                conn.Insert(user);
                conn.Close();
                return true;
            }
            catch (SQLiteException) { }
            catch (Exception) { }
            return false;
        }
        public bool LoginUser(string email, string pass)
        {
            var select = conn.Table<User>();
            var d1 = select.Where(x => x.Email == email && x.Password == pass).FirstOrDefault();
            if (d1 != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddCategory(string name)
        {
            category = new Category
            {
               Name = name
            };
            try
            {
                conn.Insert(category);
                conn.Close();
                return true;
            }
            catch (SQLiteException) { }
            catch (Exception) { }
            return false;
        }
        public IEnumerable<Category> ShowDataCategory()
        {
            var lstCategories = from category in conn.Table<Category>() select category;
            return lstCategories;
        }
        public bool AddProduct(string image, string name, string descrip, float price)
        {
            product = new Product
            {
                Image = image,
                Name = name,
                Description = descrip,
                Price = price
            };
            try
            {
                conn.Insert(product);
                conn.Close();
                return true;
            }
            catch (SQLiteException) { }
            catch (Exception) { }
            return false;
        }
        public IEnumerable<Product> ShowDataProduct()
        {
            var lstProducts = from product in conn.Table<Product>() select product;
            return lstProducts;
        }
    }
}
