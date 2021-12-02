using AppMarketShop.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppMarketShop.Data
{
    public class DataLogic
    {
        private SQLiteConnection conn;
        private User user;
        private Category category;
        private Product product;
        private DataTemporal dataTemporal;
        private Orders order;
        private OrderDetail orderDetail;
        private int id;
        public DataLogic()
        {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<User>();
            conn.CreateTable<Category>();
            conn.CreateTable<Product>();
            conn.CreateTable<Cart>();
            conn.CreateTable<OrderDetail>();
            conn.CreateTable<Orders>();
            conn.CreateTable<DataTemporal>();
        }
        public bool RegisterUser(string fullname, string email, string pass)
        {
            user = new User
            {
                FullName = fullname,
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
        public User LoginUser(string email, string pass)
        {
            User use = new User();
            var select = conn.Table<User>();
            var d1 = select.Where(x => x.Email == email && x.Password == pass).FirstOrDefault();
            use.Id = d1.Id;
            use.FullName = d1.FullName;
            use.Email = d1.Email;
            
            if (d1 != null)
            {
                return use;
            }
            else
            {
                return null;
            }
        }
        public bool AddCategory(string name, string image)
        {
            category = new Category
            {
               Name = name,
               Image = image
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
        public bool AddProduct(string image, string name, int id, string descrip, float price)
        {
            product = new Product
            {
                Image = image,
                Name = name,
                CategoryId = id,
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
        public IEnumerable<Product> ShowDataProductFilter(string Filter)
        {
            var lstProducts = from product in conn.Table<Product>().Where(p => p.Name.ToLower().Contains(Filter.ToLower())) select product;
            return lstProducts;
        }
        public IEnumerable<Product> ListProdCategory(int id)
        {
            var lstProducts = from product in conn.Table<Product>().Where(i => i.CategoryId == id) select product;
            return lstProducts;
        }
        public  bool AddToCart (DataTemporal tabla)
        {
            try
            {
                conn.Insert(tabla);
                conn.Close();
                return true;
            }
            catch (SQLiteException) { }
            catch (Exception) { }
            return false;
        }
        public IEnumerable<DataTemporal> ShowDataTemporal()
        {
            var lstDataTenporal = from dataTemporal in conn.Table<DataTemporal>() select dataTemporal;
            return lstDataTenporal;
        }
        public void DeleteAllCart()
        {
            conn.DeleteAll<DataTemporal>();
            conn.Close();
        }
        public bool RegisterPedido(List<OrderDetail> orderDetails, float total)
        {
            var ID = Convert.ToInt32(Preferences.Get("IdUser", 0));
            var Name = Preferences.Get("FullName", "");
            var Email = Preferences.Get("Email", "");
            order = new Orders
            {
                Email = Email,
                UserId = ID,
                Name = Name,
                Total = total
            };
            try
            {
                conn.Insert(order);
                var variable = conn.Query<Orders>("SELECT * FROM Orders WHERE ID = (SELECT MAX(ID) FROM Orders)").ToList();
                foreach (var s in variable)
                {
                    id = s.Id;
                }
            }
            catch (SQLiteException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            
            try
            {
                foreach (var orderdetail in orderDetails)
                {
                    orderDetail = new OrderDetail
                    {
                        OrderId = id,
                        ProductId = orderdetail.ProductId,
                        Description = orderdetail.Description,
                        Quantity = orderdetail.Quantity,
                        Price = orderdetail.Price,
                        Total = orderdetail.Total
                    };
                    conn.Insert(orderDetail);
                }
                return true;
            }
            catch (SQLiteException) { }
            catch (Exception) { }
            return false;
        }
        public IEnumerable<Orders> ShowDataOrders()
        {
            var lstOrders = from order in conn.Table<Orders>() select order;
            return lstOrders;
        }
    }
}
