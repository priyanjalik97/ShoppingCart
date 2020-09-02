using OnlineShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShoppingCartDAL
{
    public class CustomerDB
    {
        OSCDbContext OSCDbContext;
        public CustomerDB()
        {
            OSCDbContext = new OSCDbContext();
        }
        public IEnumerable<Customer> GetAll()
        {
            IEnumerable<Customer> customers = OSCDbContext.Customers.ToList();
            return customers;
        }
        public Customer GetById(int Id)
        {
            Customer customers = OSCDbContext.Customers.Find(Id);
            return customers;
        }
        public void Add(Customer customer)
        {
            OSCDbContext.Customers.Add(customer);
        }
        public void Save()
        {
            OSCDbContext.SaveChanges();
        }
    }
}
