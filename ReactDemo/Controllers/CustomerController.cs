using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactDemo.Models;

namespace ReactDemo.Controllers
{
    public class CustomerController : Controller
    {
        ReactDemoContext db = new ReactDemoContext();
        public IEnumerable<Customer> Index()
        {
            var cust = db.Customer.ToList();
            return cust;
        }
        public int AddCustomer(Customer cust)
        {
            string currId = db.Customer.Max(m => m.CustomerId);
            int curr = Convert.ToInt32(currId) + 1;
            cust.CustomerId = Convert.ToString(curr);
            db.Customer.Add(cust);
            db.SaveChanges();
            return 1;
        }
        public Customer GetCustomerData(string id)
        {
            //int id1 = Convert.ToInt32(id);
            Customer cust = db.Customer.Find(id);
            return cust;
        }
        public int UpdateCustomer(Customer cust)
        {
            db.Entry(cust).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return 1;
        }
        public int DeleteCustomer(string id)
        {
            Customer cust = db.Customer.Find(id);
            db.Customer.Remove(cust);
            db.SaveChanges();
            return 1;
        }
    }
}