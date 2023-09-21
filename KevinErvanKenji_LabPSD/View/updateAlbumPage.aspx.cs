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
    public partial class updateAlbumPage : System.Web.UI.Page
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        AlbumController ac = new AlbumController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                String id = Request["ID"];
                Album updateMenu = db.Albums.Find(id);

                List<Album> typeName = (from m in db.Albums select m).ToList();

                nameAlbum.Text = updateMenu.AlbumName;
                descAlbum.Text = updateMenu.AlbumDescription;
                priceAlbum.Text = updateMenu.AlbumPrice.ToString();
                stockAlbum.Text = updateMenu.AlbumStock.ToString();
                
            }
        }

        protected void updateAlbumBtn_Click(object sender, EventArgs e)
        {
            String id = Request["ID"];
            String name = nameAlbum.Text;
            String description = descAlbum.Text;
            String price = priceAlbum.Text;
            String stock = stockAlbum.Text;

            if (!ac.nameAlbumValidation1(name))
            {
                errorAlbum.Text = "Name must be filled!";
            }
            else if (!ac.nameAlbumValidation2(name))
            {
                errorAlbum.Text = "Name must be filled less than 50 characters!";
            }
            else if (!ac.nameDescValidation1(description))
            {
                errorAlbum.Text = "Description must be filled!";
            }
            else if (!ac.nameDescValidation2(description))
            {
                errorAlbum.Text = "Description must be filled less than 255 characters!";
            }
            else if (!ac.priceValidation1(price))
            {
                errorAlbum.Text = "Price must be filled!";
            }
            else if (!ac.priceValidation2(price))
            {
                errorAlbum.Text = "Price must be filled between 100000 and 1000000";
            }
            else if (!ac.stockValidation1(stock))
            {
                errorAlbum.Text = "Stock must be filled!";
            }
            else if (!ac.stockValidation2(stock))
            {
                errorAlbum.Text = "Stock must be filled more than 0!";
            }
            else if (albumImg.HasFile)
            {
                Album currAlb = (from m in db.Albums select m).ToList().FirstOrDefault();

                int stockCon = Convert.ToInt32(stock);
                int priceCon = Convert.ToInt32(price);

                Album updateMenu = db.Albums.Find(id);
                updateMenu.AlbumName = name;
                updateMenu.AlbumDescription = description;
                updateMenu.AlbumStock = stockCon;
                updateMenu.AlbumPrice = priceCon;

                String nameFile = DateTime.Now.ToString("yyyyMMddHHmmss");
                String pathFile = Server.MapPath("~/Assets/Albums/" + nameFile);
                albumImg.SaveAs(pathFile);

                db.SaveChanges();
                Response.Redirect("~/View/artistDetailPage.aspx");
            }
            else
            {
                errorAlbum.Text = "Update error!";
            }
        }
    }
}