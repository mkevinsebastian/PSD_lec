using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KevinErvanKenji_LabPSD.Model;
using KevinErvanKenji_LabPSD.Factory;

namespace KevinErvanKenji_LabPSD.Repository
{
    public class TransactionRepos
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        public List<Customer> getCustomer()
        {
            return (from m in db.Customers select m).ToList();
        }
        public List<TransactionHeader> getTH()
        {
            return (from m in db.TransactionHeaders select m).ToList();
        }
        public List<Album> getAlbum()
        {
            return (from m in db.Albums select m).ToList();
        }
    }
}