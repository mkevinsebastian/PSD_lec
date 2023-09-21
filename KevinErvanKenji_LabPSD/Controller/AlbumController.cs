using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KevinErvanKenji_LabPSD.Factory;
using KevinErvanKenji_LabPSD.Repository;
using KevinErvanKenji_LabPSD.Model;

namespace KevinErvanKenji_LabPSD.Controller
{
    public class AlbumController
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        public bool nameAlbumValidation1(String nameAlbum)
        {
            if(nameAlbum == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool nameAlbumValidation2(String nameAlbum)
        {
            if (nameAlbum.Length > 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool nameDescValidation1(String descAlbum)
        {
            if(descAlbum == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool nameDescValidation2(String descAlbum)
        {
            if (descAlbum.Length > 255)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool priceValidation1 (String priceAlbum)
        {
            if(priceAlbum == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool priceValidation2(String priceAlbum)
        {
            if (priceAlbum.Length < 100000 || priceAlbum.Length > 1000000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool stockValidation1(String stockAlbum)
        {
            if (stockAlbum == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool stockValidation2 (String stockAlbum)
        {
            if(stockAlbum.Length < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validateAlbum(String albumName)
        {
            Album find = (from x in db.Albums where x.AlbumName == albumName select x).FirstOrDefault();
            if(find != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}