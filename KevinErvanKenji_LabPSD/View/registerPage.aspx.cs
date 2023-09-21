using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KevinErvanKenji_LabPSD.Model;
using KevinErvanKenji_LabPSD.Factory;
using KevinErvanKenji_LabPSD.Controller;
using KevinErvanKenji_LabPSD.Repository;
using KevinErvanKenji_LabPSD.Handler;

namespace KevinErvanKenji_LabPSD
{
    public partial class registerPage : System.Web.UI.Page
    {
        DatabaseEntities db = DatabaseSingleton.getDB();
        RegisterController rc = new RegisterController();
        CustomerRepos cr = new CustomerRepos();
        GenerateID gid = new GenerateID();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void regBtn_Click(object sender, EventArgs e)
        {
            String registerName = nameReg.Text;
            String registerEmail = emailReg.Text;

            String registerGender = regGender.SelectedValue;

            String registerAddress = addressReg.Text;
            String registerPassword = passwordReg.Text;

            if (!rc.nameValidation(registerName))
            {
                regError.Text = "Name must be filled between 5 to 50 characters!";
            }
            else if (!rc.emailValidation1(registerEmail))
            {
                regError.Text = "Email must be filled!";
            }
            else if (!rc.emailValidation2(registerEmail))
            {
                regError.Text = "Must use @ when entering an email account!";
            }
 
            else if (!rc.genderValidation(registerGender)){
                regError.Text = "Gender type must be Selected!";
            }

            else if (!rc.addressValidation1(registerAddress))
            {
                regError.Text = "Address must be filled!";
            }
            else if (!rc.addressValidation2(registerAddress))
            {
                regError.Text = "Address must be ended with 'Street'!";
            }
            else if (!rc.passwordValidation1(registerPassword))
            {
                regError.Text = "Password must be filled more than 4 characters!";
            }
            else if (!rc.passwordValidation2(registerPassword))
            {
                regError.Text = "Password must be filled with numeric characters!";
            }
            else
            {
                // Menambah ID + 1 sebanyak Customer yang di generate
                int custId = gid.generateID();
                cr.registerCustomer(custId, registerName, registerEmail, registerGender, registerPassword, registerAddress);
                regError.Text = "Email submitted successfully!";
                Response.Redirect("~/View/loginPage.aspx");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}