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

        public static void insert(Unit unit)
        {
            UnitDAO.insert(unit);
        }

        public static void update(Unit unit)
        {
            UnitDAO.update(unit);
        }
    }
}
