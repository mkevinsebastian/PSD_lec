using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KevinErvanKenji_LabPSD
{
    public partial class NavBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/View/registerPage.aspx");
        }

        protected void homeBtnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/View/homePage.aspx");
        }

        protected void loginBtnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/View/loginPage.aspx");
        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/homePage.aspx");
        }
    }
}