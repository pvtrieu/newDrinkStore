using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;
using DrinkStore.DAO;

namespace DrinkStore.BUS
{
    class ImportDetailBUS
    {
        public static List<ImportDetail> getAll(Import import)
        {
            try
            {
                return ImportDetailDAO.getAll(import);
            }
            catch
            {
                return null;
            }
        }

        public static void add(ImportDetail detail)
        {
            ImportDetailDAO.add(detail);
        }

        public static void update(ImportDetail detail)
        {
            ImportDetailDAO.update(detail);
        }

        public static void delete(ImportDetail detail)
        {
            ImportDetailDAO.delete(detail);
        }
    }
}
