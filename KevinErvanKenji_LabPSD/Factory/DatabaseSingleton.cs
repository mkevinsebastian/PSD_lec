using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KevinErvanKenji_LabPSD.Model;

namespace KevinErvanKenji_LabPSD.Factory
{
    public class DatabaseSingleton
    {
        private static DatabaseEntities db = null;

        public static DatabaseEntities getDB()
        {
            if(db == null)
            {
                db = new DatabaseEntities();
            }
            return db;
        }
    }
}