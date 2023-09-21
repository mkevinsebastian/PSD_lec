using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KevinErvanKenji_LabPSD.Factory;
using KevinErvanKenji_LabPSD.Model;

namespace KevinErvanKenji_LabPSD.Repository
{
    public class CustomerRepos
    {
        DatabaseEntities db = new DatabaseEntities();
        public void registerCustomer(int id, String name, String email, String password, String gender, String address)
        {
            Customer newCust = CustomerFactory.createCust(id, name, email, password, gender, address);
            db.Customers.Add(newCust);
            db.SaveChanges();
        }
        public Customer findEmail(String email)
        {
            Customer customerFind = (from x in db.Customers where x.CustomerEmail == email select x).FirstOrDefault();
            return customerFind;
        }

        public Customer findID(int id)
        {
            Customer customerFind = (from x in db.Customers where x.CustomerID == id select x).FirstOrDefault();
            return customerFind;
        }
    }
}