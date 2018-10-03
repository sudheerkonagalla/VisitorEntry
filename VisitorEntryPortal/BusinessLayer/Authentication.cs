using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Collections;
using System.Configuration;
using VisitorEntryPortal.Models;

namespace VisitorEntryPortal.BusinessLayer
{
    public class Authentication
    {
        public static Boolean Authenticate(string UserName, string Password)
        {
            byte[] EncryptedPassword = Common.EncryptPassword(Password);
            string EncryptedStringPassword = Convert.ToBase64String(EncryptedPassword);
            string UserPassword = Authentication.GetPassword(UserName);
            if (UserPassword.Equals(EncryptedStringPassword))
            {
                return true;
            }
            return false;
        }

        public static string GetPassword(string UserName)
        {
            using (VisitorEntities VisitorEntry = new VisitorEntities())
            {
                userlogin user = VisitorEntry.userlogins.Where(v => v.username == UserName).FirstOrDefault();
                return user!= null ? user.password: "";
            }
                
        }
    }
}