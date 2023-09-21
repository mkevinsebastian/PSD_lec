using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KevinErvanKenji_LabPSD.Model;
using KevinErvanKenji_LabPSD.Factory;

namespace KevinErvanKenji_LabPSD.Repository
{
    public class ArtistRepos
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        public void addArtist(Artist artistReg)
        {
            db.Artists.Add(artistReg);
            db.SaveChanges();
        }
    }
}