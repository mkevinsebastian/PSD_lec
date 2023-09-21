using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KevinErvanKenji_LabPSD.Model;
using KevinErvanKenji_LabPSD.Factory;
using KevinErvanKenji_LabPSD.Controller;

namespace KevinErvanKenji_LabPSD.View
{
    public partial class updateArtistPage : System.Web.UI.Page
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        ArtistController ac = new ArtistController;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                String id = Request["ID"];
                Artist updateMenu = db.Artists.Find(id);

                List<Artist> typeName = (from m in db.Artists select m).ToList();

                nameArtist.Text = updateMenu.ArtistName;

            }
        }

        protected void updateArtistBtn_Click(object sender, EventArgs e)
        {
            String id = Request["ID"];
            String name = nameArtist.Text;
            var imgA = artistImg;
            if(!ac.artistName(name)){
                errorArtist.Text = "Name length must be more than 2 character!";
            }
            else if(imgA != "png" && imgA != "jpg" && imgA != "jpeg" && imgA != "jfif")
            {
                errorArtist.Text = "File must be in jpg, png, jpeg or jfif";
            }
            else
            {

                Artist currArt = (from m in db.Artists select m).ToList().FirstOrDefault();

                Artist updateMenu = db.Artists.Find(id);
                updateMenu.ArtistName = name;

                String nameFile = DateTime.Now.ToString("yyyyMMddHHmmss");
                String pathFile = Server.MapPath("~/Assets/Albums/" + nameFile);
                artistImg.SaveAs(pathFile);

                db.SaveChanges();
                Response.Redirect("~/View/artistDetailPage.aspx");
            }
        }
    }
}