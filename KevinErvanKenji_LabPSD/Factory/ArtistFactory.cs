using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KevinErvanKenji_LabPSD.Model;

namespace KevinErvanKenji_LabPSD.Factory
{
    public class ArtistFactory
    {
        public static Artist createArtist(int id, String name)
        {
            Artist newArtist = new Artist();
            newArtist.ArtistID = id;
            newArtist.ArtistName = name;

            return newArtist;
        }
    }
}