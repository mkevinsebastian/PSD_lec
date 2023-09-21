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
    public partial class updateProfilePage : System.Web.UI.Page
    {
       DatabaseEntities db = DatabaseSingleton.getDB();
       RegisterController rc = new RegisterController();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)
            {
                String id = Request["ID"];
                Customer updateMenu = db.Customers.Find(id);

                List<Customer> typeName = (from m in db.Customers select m).ToList();

                nameUpdate.Text = updateMenu.CustomerName;
                emailUpdate.Text = updateMenu.CustomerEmail;
                addressUpdate.Text = updateMenu.CustomerAddress;
                passwordUpdate.Text = updateMenu.CustomerPassword;

            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            String id = Request["ID"];
            String updateName = nameUpdate.Text;
            String updateEmail = emailUpdate.Text;

            String updateGender = updGender.SelectedValue;

            String updateAddress = addressUpdate.Text;
            String updatePassword = passwordUpdate.Text;

            if (!rc.nameValidation(updateName))
            {
                updateError.Text = "Name must be filled between 5 to 50 characters!";
            }
            else if (!rc.emailValidation1(updateEmail))
            {
                updateError.Text = "Email must be filled!";
            }
            else if (!rc.emailValidation2(updateEmail))
            {
                updateError.Text = "Must use @ when entering an email account!";
            }

            else if (!rc.genderValidation(updateGender))
            {
                updateError.Text = "Gender type must be Selected!";
            }

            else if (!rc.addressValidation1(updateAddress))
            {
                updateError.Text = "Address must be filled!";
            }
            else if (!rc.addressValidation2(updateAddress))
            {
                updateError.Text = "Address must be ended with 'Street'!";
            }
            else if (!rc.passwordValidation1(updatePassword))
            {
                updateError.Text = "Password must be filled more than 4 characters!";
            }
            else if (!rc.passwordValidation2(updatePassword))
            {
                updateError.Text = "Password must be filled with numeric characters!";
            }
            else
            {
                String typeID = (from m in db.Customers select m.CustomerName).ToList().FirstOrDefault();

                Customer updateMenu = db.Customers.Find(id);
                updateMenu.CustomerName = updateName;
                updateMenu.CustomerEmail = updateEmail;
                updateMenu.CustomerAddress = updateAddress;
                updateMenu.CustomerGender = updateGender;
                updateMenu.CustomerPassword = updatePassword;

                db.SaveChanges();
                Response.Redirect("~/View/loginPage.aspx");
            }
        }
    }
}