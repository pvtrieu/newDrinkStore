using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.DAO;
using DrinkStore.Entities;

namespace DrinkStore.BUS
{
    class StaffBUS
    {
        public static Staff getByUsername(string username)
        {
            return StaffDAO.getByUsername(username);
        }

        public static bool valid(string username, string password)
        {
            Staff staff = StaffDAO.getByUsername(username);
            if (staff.Password == password)
                return true;
            else
                return false;
        }
    }
}
