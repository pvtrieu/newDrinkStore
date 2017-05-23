using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class StaffDAO
    {
        public static Staff getByUsername(string username)
        {
            using (DSModel model = new DSModel())
            {
                Staff staff = model.Staffs.Where(x => x.Username == username).FirstOrDefault();
                return staff;
            }
        }

        public static Staff getByID(int staffID)
        {
            using (DSModel model = new DSModel())
            {
                Staff staff = model.Staffs.Find(staffID);
                return staff;
            }
        }

        public static List<Staff> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Staffs.ToList();
            }
        }

        public static List<Staff> search(string name, string position)
        {
            using (DSModel model = new DSModel())
            {
                return model.Staffs.Where(x => x.Name.Contains(name)
                                            || x.PositionCode == position)                                         
                                            .ToList();
            }
        }

        public static void add(Staff staff)
        {
            using (DSModel model = new DSModel())
            {
                model.Staffs.Add(staff);
                model.SaveChanges();
            }
        }

        public static void update(Staff staff)
        {
            using (DSModel model = new DSModel())
            {
                var updateStaff = model.Staffs.Find(staff.StaffID);
                model.Entry(updateStaff).CurrentValues.SetValues(staff);
                model.SaveChanges();
            }
        }

        public static void delete(Staff staff)
        {
            using (DSModel model = new DSModel())
            {
                var deleteStaff = model.Staffs.Find(staff.StaffID);
                model.Staffs.Remove(deleteStaff);
                model.SaveChanges();
            }
        }
    }
}
