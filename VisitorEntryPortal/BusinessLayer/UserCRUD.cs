using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisitorEntryPortal.Models;

namespace VisitorEntryPortal.BusinessLayer
{
    public class UserCRUD
    {
        public static int AddNewUser(user NewUser
            
            )
        {
            using (VisitorEntities VisitorEntry = new VisitorEntities())
            {
                VisitorEntry.users.Add(NewUser);
                VisitorEntry.SaveChanges();
                return NewUser.id;
            }
        }

    public static void CreateLoginUser(
        string FirstName,
        string LastName,
        string Email,
        int phone,
        string UserName,
        string Password,
        string type
        )
    {
        using (VisitorEntities VisitorEntry = new VisitorEntities())
        {
            int TypeID = VisitorEntry.lookups.Where(l => l.code == type).FirstOrDefault().id;
            user NewUser = new user();
            NewUser.firstname = FirstName;
            NewUser.lastname = LastName;
            NewUser.email = Email;
            NewUser.contactnumber = phone;
            NewUser.typeid = (short)TypeID;
            NewUser.created_on = DateTime.Now;

            int UserID = UserCRUD.AddNewUser(NewUser);
            string EncryptedPassword = System.Text.Encoding.UTF32.GetString(Common.EncryptPassword(Password));

            userlogin NewUserLogin = new userlogin();
            NewUserLogin.userid = UserID;
            NewUserLogin.username = UserName;
            NewUserLogin.password = EncryptedPassword;
            NewUserLogin.created_on = DateTime.Now;

                VisitorEntry.userlogins.Add(NewUserLogin);
            }
        }
        public static void DeleteUser()
        {

        }

        public static void UpdateUser()
        {

        }
    }
}