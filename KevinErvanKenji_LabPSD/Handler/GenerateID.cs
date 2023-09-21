using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KevinErvanKenji_LabPSD.Model;
using KevinErvanKenji_LabPSD.Factory;

namespace KevinErvanKenji_LabPSD.Handler
{
    public class GenerateID
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        public int generateID()
        {
            int id;
            int lastID = (from m in db.Customers select m.CustomerID).LastOrDefault();

            if (lastID == null)
            {
                id = 1;
            }
            else
            {
                id = lastID + 1;
            }
            return id;
        }
    }
}