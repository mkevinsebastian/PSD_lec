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
    public partial class albumDetail : System.Web.UI.Page
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Album> menuList = (from m in db.Albums select m).ToList();
            MenuView.DataSource = menuList;
            MenuView.DataBind();
        }

        protected void addCartBtn_Click(object sender, EventArgs e)
        {

        }
    }
}