using OnlineShoppingCart;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OnlineShoppingCartDAL
{
    public class ProductDB
    {
        OSCDbContext OSCDbContext;
        public ProductDB()
        {
            OSCDbContext = new OSCDbContext();
        }
        public IEnumerable<Product> GetAll()
        {
            IEnumerable<Product> Products = OSCDbContext.Products.ToList();
            return Products;
        }
        public Product GetById(int Id)
        {
            Product Products = OSCDbContext.Products.Find(Id);
            return Products;
        }
        public void Add(Product Product)
        {
            OSCDbContext.Products.Add(Product);
        }
        public void Update(Product Product)
        {
            OSCDbContext.Products.Update(Product);
        }
        public void Delete(Product Product)
        {
            OSCDbContext.Products.Remove(Product);
        }
        public void Save()
        {
            OSCDbContext.SaveChanges();
        }
    }
}
