using DrinkStore.DAO;
using DrinkStore.Entities;
using System.Collections.Generic;

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

        public static Staff getByID(int staffID)
        {
            return StaffDAO.getByID(staffID);
        }

        public static List<Staff> getAll()
        {
            return StaffDAO.getAll();
        }
        public static bool add(Staff staff)
        {
            try
            {
                StaffDAO.add(staff);
                return true;
            }
            catch
            {
                return false;
            }
           
        }

        public static bool update(Staff staff)
        {
            try
            {
                StaffDAO.update(staff);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void delete(Staff staff)
        {
            StaffDAO.delete(staff);
        }

        public static List<Staff> search(string name, string position)
        {
            return StaffDAO.search(name, position);
        }
    }
}
