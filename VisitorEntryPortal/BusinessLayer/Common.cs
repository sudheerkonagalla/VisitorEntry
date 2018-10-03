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
    public class Common
    {
        public static byte[] EncryptPassword(String Password)
        {
            string Salt = ConfigurationManager.AppSettings["Salt"];
            // Adding Salt to the Password
            Password += Salt;

            byte[] PasswordByte = System.Text.Encoding.UTF32.GetBytes(Password);
           // SHA1 sha1 = new SHA1CryptoServiceProvider();
            HashAlgorithm hm = HashAlgorithm.Create("SHA1");

            byte[] EncryptedPassword = hm.ComputeHash(PasswordByte);
            return EncryptedPassword;
        }

        public static company GetCompany(string UserName)
        {
            using (VisitorEntities visitorEntry = new VisitorEntities())
            {
                userlogin LoginDetails = visitorEntry.userlogins.Where(u => u.username == UserName).FirstOrDefault();
                company CompanyDetails = visitorEntry.companies.Where(l => l.id == LoginDetails.companyid).FirstOrDefault();
                return CompanyDetails;
            }
        }

    }
}