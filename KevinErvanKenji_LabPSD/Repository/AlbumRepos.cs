using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KevinErvanKenji_LabPSD.Model;
using KevinErvanKenji_LabPSD.Factory;

namespace KevinErvanKenji_LabPSD.Repository
{
    public class AlbumRepos
    {
        DatabaseEntities db = DatabaseSingleton.getDB();

        public void addAlbum(Album albumReg)
        {
            db.Albums.Add(albumReg);
            db.SaveChanges();
        }
        public Album getId(int id)
        {
            Album find = (from m in db.Albums where id == m.AlbumID select m).FirstOrDefault();
            return find;
        }
        public Album getNameAlbum(String name)
        {
            Album find = (from m in db.Albums where name == m.AlbumName select m).FirstOrDefault();
            return find;
        }
        
    }
}