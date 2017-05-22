using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class UnitDAO
    {
        public static List<Unit> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Units.ToList();
            }
        }
        public static Unit getById(int id)
        {
            using (DSModel model = new DSModel())
            {
                return model.Units.Find(id);
            }
        }

        public static void insert(Unit unit)
        {
            using (DSModel model = new DSModel())
            {
                model.Units.Add(unit);
                model.SaveChanges();
            }
        }

        public static void update(Unit unit)
        {
            using (DSModel model = new DSModel())
            {
                var updateUnit = model.Units.Find(unit.UnitID);
                model.Entry(updateUnit).CurrentValues.SetValues(unit);
                model.SaveChanges();
            }
        }
    }
}
