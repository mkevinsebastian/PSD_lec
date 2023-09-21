using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KevinErvanKenji_LabPSD.Model;
using KevinErvanKenji_LabPSD.Factory;
using KevinErvanKenji_LabPSD.Repository;

namespace KevinErvanKenji_LabPSD.View
{
    public partial class cartPage1 : System.Web.UI.Page
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        CustomerRepos cr = new CustomerRepos();
        CartRepos cre = new CartRepos();
        public List<Cart> allCart = new List<Cart>();
        protected void Page_Load(object sender, EventArgs e)
        {
            int customerID = Convert.ToInt32(Request.Cookies["User"].Value);
            Cookies.Value = cr.findID(customerID).ToString();
            //List<Cart> list = (from x in db.Carts where x.CustomerID == customerID select x).ToList();
            allCart = cre.getCart();
        }
        protected void RemoveBtnClick(object sender, EventArgs e)
        {
           
        }
        protected void checkoutBtnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/View/transactionHistory.aspx");
        }
}