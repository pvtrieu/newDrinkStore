using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class ImportDAO
    {
        public static void add(Import import)
        {
            using (DSModel model = new DSModel())
            {
                model.Imports.Add(import);
                model.SaveChanges();
            }
        }

        public static void update(Import import)
        {
            using (DSModel model = new DSModel())
            {
                var updateImport = model.Imports.Find(import.ImportID);
                model.Entry(updateImport).CurrentValues.SetValues(import);
                model.SaveChanges();
            }
        }

        public static void delete(Import import)
        {
            using (DSModel model = new DSModel())
            {
                var delImport = model.Imports.Find(import.ImportID);
                model.Imports.Remove(delImport);
                model.SaveChanges();
            }
        }

        public static void sumCost(Import import)
        {
            using (DSModel model = new DSModel())
            {
                var sumImport = model.Imports.Find(import.ImportID);
                import.TotalCost = model.ImportDetails.Where(x => x.ImportID == import.ImportID).
                                                                Sum(x => x.UnitCost * x.Amount);
                model.Entry(sumImport).CurrentValues.SetValues(import);
                model.SaveChanges();
            }
        }

        public static List<Import> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Imports.ToList();
            }
        }

    }
}
