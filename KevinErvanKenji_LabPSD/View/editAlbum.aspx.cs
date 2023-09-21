using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KevinErvanKenji_LabPSD.Factory;
using KevinErvanKenji_LabPSD.Model;
using KevinErvanKenji_LabPSD.Repository;
using KevinErvanKenji_LabPSD.Controller;
using KevinErvanKenji_LabPSD.Handler;

namespace KevinErvanKenji_LabPSD.View
{
    public partial class editAlbum : System.Web.UI.Page
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        String tempName;
        AlbumController ac = new AlbumController();
        AlbumRepos ar = new AlbumRepos();
        GenerateID gid = new GenerateID();

        protected void Page_Load(object sender, EventArgs e)
        {
            String albumName = Request.QueryString["AlbumName"];
            if(albumName == null)
            {
                errorEdit.Text = "Album not found!";
                Response.Redirect("~/View/homePageAdmin.aspx");
            }
            if (!IsPostBack)
            {
                if (Request.Cookies["User"] != null)
                {
                    int customerID = Convert.ToInt32(Request.Cookies["User"].Value);

                    Customer findCustomer = (from m in db.Customers where customerID == m.CustomerID select m).FirstOrDefault();

                    if (findCustomer.CustomerRole == "Admin")
                    {
                        Response.Redirect("~/View/homePageAdmin.aspx");
                    }
                    else if (findCustomer.CustomerRole == "Cust")
                    {
                        errorEdit.Text = "Access invalid!";
                    }
                    else
                    {
                        errorEdit.Text = "Failed!";
                    }
                }
                else
                {
                    Response.Redirect("~/View/homePageAdmin.aspx");
                }

                Album currAlb = (from m in db.Albums where albumName == m.AlbumName select m).FirstOrDefault();
                tempName = currAlb.AlbumName;
                Image1.ImageUrl = currAlb.AlbumImage;
                int currId = currAlb.AlbumID;

                nameEdit.Text = currAlb.AlbumName;
                descEdit.Text = currAlb.AlbumDescription;
                priceEdit.Text = currAlb.AlbumPrice.ToString();
                stockEdit.Text = currAlb.AlbumStock.ToString();
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            String name = nameEdit.Text;
            String description = descEdit.Text;
            String price = priceEdit.Text;
            String stock = stockEdit.Text;

            int priceCon = Convert.ToInt32(price);
            int stockCon = Convert.ToInt32(stock);

            if (name != tempName)
            {
                errorEdit.Text = "Name exist already!";
            }
            else if (!ac.validateAlbum(name)){
                errorEdit.Text = "Can't generate, name exist already!";
            }
            else if (imageUpload.HasFile) {
                String nameFile = DateTime.Now.ToString("yyyyMMddHHmmss");
                String pathFile = Server.MapPath("~/Assets/Albums/" + nameFile);
                imageUpload.SaveAs(pathFile);

                String img = "/Assets/Album/" + nameFile;
                int id = gid.generateID();

                Album generateAlbum = AlbumFactory.createAlbum(id, name, description, priceCon, stockCon);
                ar.addAlbum(generateAlbum);
                errorEdit.Text = "Upload success!";
            }
            else
            {
                errorEdit.Text = "Error!";
            }
        }
    }
}