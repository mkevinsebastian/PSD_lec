using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KevinErvanKenji_LabPSD.Model;
using KevinErvanKenji_LabPSD.Factory;
using KevinErvanKenji_LabPSD.Repository;

namespace KevinErvanKenji_LabPSD
{
    public partial class loginPage : System.Web.UI.Page
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            String email = emailBox.Text;
            String password = passwordBox.Text;
            errorLabel.Text = "";

            if (db.Customers.Any(x => x.CustomerEmail == email))
            {
                if (db.Customers.Any(x => x.CustomerEmail == email && x.CustomerPassword == password))
                {
                    Customer customerFound = (from x in db.Customers where x.CustomerEmail == email && x.CustomerPassword == password select x).FirstOrDefault();
                    HttpCookie cookie = new HttpCookie("User"); 
                    cookie.Expires = DateTime.Now.AddHours(10);
                    cookie.Value = customerFound.CustomerID.ToString();
                    Response.Cookies.Add(cookie);
                    Response.Redirect("homePageAdmin.aspx");
                }
                else
                {
                    errorLabel.Text = "Password incorrect!";
                }
            }
            else
            {
                errorLabel.Text = "Email incorrect!";
            }
        }

        protected void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}