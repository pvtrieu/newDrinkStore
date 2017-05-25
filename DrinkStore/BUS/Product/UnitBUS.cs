using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;
using DrinkStore.DAO;

namespace DrinkStore.BUS
{
    class UnitBUS
    {
        public static List<Unit> getAll()
        {
            return UnitDAO.getAll();
        }

        public static Unit getById(int id)
        {
            return UnitDAO.getById(id);
        }

        public static bool add(Unit unit)
        {
            try
            {
                UnitDAO.add(unit);
                return true;
            }
            catch
            {
                return false;
            }      
        }

        public static bool update(Unit unit)
        {
            try
            {
                UnitDAO.update(unit);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
