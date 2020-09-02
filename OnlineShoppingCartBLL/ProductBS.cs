using OnlineShoppingCart;
using OnlineShoppingCartDAL;
using System;
using System.Collections.Generic;

namespace OnlineShoppingCartBLL
{
    public class ProductBS
    {
        ProductDB productDb;

        public ProductBS()
        {
            productDb = new ProductDB();
        }
        public IEnumerable<Product> GetAll()
        {
           
            return productDb.GetAll();
        }
        public Product GetById(int Id)
        {
           
            return productDb.GetById(Id);
        }
        public void Add(Product Product)
        {
            productDb.Add(Product);
        }
        public void Update(Product Product)
        {
            productDb.Update(Product);
        }
        public void Delete(Product Product)
        {
            productDb.Delete(Product);
        }
        public void Save()
        {
            productDb.Save();
        }
    }
}
