using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KevinErvanKenji_LabPSD.Model;
using KevinErvanKenji_LabPSD.Factory;

namespace KevinErvanKenji_LabPSD.View
{
    public partial class artistDetailPage : System.Web.UI.Page
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Artist> menuList = (from m in db.Artists select m).ToList();
            MenuView.DataSource = menuList;
            MenuView.DataBind();
        }

        protected void InsertBtn2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/insertAlbum.aspx");
        }

        protected void MenuView_RowEditing(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = MenuView.Rows[e.RowIndex];
            String id = row.Cells[1].Text.ToString();

            Response.Redirect("~/View/updateAlbumPage.aspx?ID=" + id);
        }
        protected void MenuView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = MenuView.Rows[e.RowIndex];
            String id = row.Cells[1].Text.ToString();
            int idCon = Convert.ToInt32(id);

            Artist targetMenu = db.Artists.Find(idCon);

            db.Artists.Remove(targetMenu);
            db.SaveChanges();

            List<Artist> menuList = (from m in db.Artists select m).ToList();
            MenuView.DataSource = menuList;
            MenuView.DataBind();
        }

        protected void MenuView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}