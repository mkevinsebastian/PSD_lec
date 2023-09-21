using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KevinErvanKenji_LabPSD.View
{
    public partial class NavbarAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void homeABtn_Click1A(object sender, EventArgs e)
        {
            Response.Redirect("~/View/homePageAdmin.aspx");
        }

        protected void logoutABtn_Click1A(object sender, EventArgs e)
        {
            if (Request.Cookies["User"] != null)
            {
                HttpCookie myCookie = new HttpCookie("User");
                myCookie.Expires = DateTime.Now.AddMonths(-12);
                Response.Cookies.Add(myCookie);
                Response.Redirect("~homePage.aspx");
            }
        }

        protected void updateABtn_Click1A(object sender, EventArgs e)
        {
            Response.Redirect("~/View/updateProfilePage.aspx");
        }

        protected void transactionBtnA_Click(object sender, EventArgs e)
        {

        }
    }
}