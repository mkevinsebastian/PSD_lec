using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KevinErvanKenji_LabPSD.Controller
{
    public class RegisterController
    {
        public bool nameValidation(String registerName)
        {
            if (registerName.Length < 5 || registerName.Length > 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool emailValidation1(String registerEmail)
        {
            if(registerEmail.Length < 6)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool emailValidation2(String registerEmail)
        {
            if (registerEmail.IndexOf("@") == -1)
            {
                return false;
            }
            else if (registerEmail.EndsWith(".com") == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public bool genderValidation(String registerGender)
        {
            if (registerGender != "Male" && registerGender == "Female")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool addressValidation1(String registerAddress)
        {
            if (registerAddress.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool addressValidation2(String registerAddress)
        {
            if (registerAddress.EndsWith("Street"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool passwordValidation1(String registerPassword)
        {
            if(registerPassword.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool passwordValidation2(String registerPassword)
        {
            // Validasi menggunakan special case
            if (registerPassword == "^(?=.*[a-zA-Z])(?=.*\\d).+$")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}