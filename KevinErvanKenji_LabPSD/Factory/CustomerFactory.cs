using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KevinErvanKenji_LabPSD.Model;

namespace KevinErvanKenji_LabPSD.Factory
{
    public class CustomerFactory
    {
        public static Customer createCust(int id, String name, String email, String password, String gender, String address)
        {
            Customer newCust = new Customer();
            newCust.CustomerID = id;
            newCust.CustomerName = name;
            newCust.CustomerEmail = email;
            newCust.CustomerPassword = password;
            newCust.CustomerGender = gender;
            newCust.CustomerAddress = address;
            newCust.CustomerRole = "Cust";

            return newCust;

        }
    }
}