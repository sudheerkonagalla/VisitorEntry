using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisitorEntryPortal.Models;

namespace VisitorEntryPortal.BusinessLayer
{
    public class EmployeServices
    {
        public static user GetEmployeDetails(string EmpID)
        {
            using (VisitorEntities VisitorEntry = new VisitorEntities())
            {
                employee emp = VisitorEntry.employees.Where(e => e.id == Convert.ToInt32(EmpID)).FirstOrDefault();
                return VisitorEntry.users.Where(u => u.id == emp.userid).FirstOrDefault();
            }
        }
        public static void LateLogOutRegister()
        {

        }

        public static void WekendRegister()
        {

        }

        public static void AssignTempBadge()
        {

        }
    }
}