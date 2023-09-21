using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KevinErvanKenji_LabPSD.Controller
{
    public class ArtistController
    {
        public bool artistName(String name)
        {
            if (name.Length > 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool artistImg(String img)
        {
            if(img != "png" && img != "jpg" && img != "jpeg" && img != "jfif")
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