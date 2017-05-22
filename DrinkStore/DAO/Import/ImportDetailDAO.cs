using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class ImportDetailDAO
    {
        public static List<ImportDetail> getAll(Import import)
        {
            using (DSModel model = new DSModel())
            {
                return model.ImportDetails.Where(x => x.ImportID == import.ImportID).ToList();
            }
        }

        public static void add (ImportDetail detail)
        {
            using (DSModel model = new DSModel())
            {
                model.ImportDetails.Add(detail);
                model.SaveChanges();
            }
        }

        public static void update(ImportDetail detail)
        {
            using (DSModel model = new DSModel())
            {
                var updateImportDetail = model.ImportDetails.Find(detail.ImportID, detail.ProductID);
                model.Entry(updateImportDetail).CurrentValues.SetValues(detail);
                model.SaveChanges();
            }
        }

        public static void delete(ImportDetail detail)
        {
            using (DSModel model = new DSModel())
            {
                var delImportDetail = model.ImportDetails.Find(detail.ImportID, detail.ProductID);
                model.ImportDetails.Remove(delImportDetail);
                model.SaveChanges();
            }
        }
    }
}
