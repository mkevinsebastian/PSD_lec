using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KevinErvanKenji_LabPSD.Model;
using KevinErvanKenji_LabPSD.Factory;
using KevinErvanKenji_LabPSD.Controller;
using KevinErvanKenji_LabPSD.Repository;
using KevinErvanKenji_LabPSD.Handler;

namespace KevinErvanKenji_LabPSD.View
{
    public partial class insertArtist : System.Web.UI.Page
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        ArtistController ac = new ArtistController();
        ArtistRepos ar = new ArtistRepos();
        GenerateID gid = new GenerateID();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void insertArtistBtn_Click(object sender, EventArgs e)
        {
            String name = nameArtist.Text;
            var imgA = artistImg;
            if (!ac.artistName(name))
            {
                errorArtist.Text = "Name length must be more than 2 character!";
            }
            else if (imgA != "png" && imgA != "jpg" && imgA != "jpeg" && imgA != "jfif")
            {
                errorArtist.Text = "File must be in jpg, png, jpeg or jfif";
            }
            else if(imgA.HasFile)
            {
                String nameFile = DateTime.Now.ToString("yyyyMMddHHmmss");
                String pathFile = Server.MapPath("~/Assets/Albums/" + nameFile);
                imgA.SaveAs(pathFile);

                String img = "/Assets/Album/" + nameFile;
                int id = gid.generateID();

                Artist generateArtist = ArtistFactory.createArtist(id, name);
                ar.addArtist(generateArtist);
                errorArtist.Text = "Upload success!";
            }
            else
            {
                errorArtist.Text = "Upload error!";
            }
        }
    }
}