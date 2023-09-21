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
    public partial class NavbarLogin : System.Web.UI.MasterPage
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void homeABtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/homePageLogin.aspx");
        }
        protected void logOBtn_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["User"] != null)
            {
                HttpCookie myCookie = new HttpCookie("User");
                myCookie.Expires = DateTime.Now.AddMonths(-12);
                Response.Cookies.Add(myCookie);
                Response.Redirect("~/View/homePage.aspx");
            }
        }

        protected void cartBtn_Click(object sender, EventArgs e)
        {

        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/updateProfilePage.aspx");
        }
    }
    }

