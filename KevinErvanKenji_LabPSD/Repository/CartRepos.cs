using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KevinErvanKenji_LabPSD.Model;
using KevinErvanKenji_LabPSD.Factory;

namespace KevinErvanKenji_LabPSD.Repository
{
    public class CartRepos
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        public List<Cart> getCart()
        {
            return (from x in db.Carts select x).ToList();
        }
    }
}