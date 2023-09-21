using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KevinErvanKenji_LabPSD.Model;

namespace KevinErvanKenji_LabPSD.Factory
{
    public class AlbumFactory
    {
        public static Album createAlbum(int id, String name, String description, int price, int stock)
        {
            Album newAlbum = new Album();
            newAlbum.ArtistID = id;
            newAlbum.AlbumName = name;
            newAlbum.AlbumDescription = description;
            newAlbum.AlbumPrice = price;
            newAlbum.AlbumStock = stock;

            return newAlbum;
        }
    }
}