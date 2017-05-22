using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.DAO;
using DrinkStore.Entities;

namespace DrinkStore.BUS
{
    class ImportBUS
    {
        public static void add(Import import)
        {
            ImportDAO.add(import);
        }

        public static void update(Import import)
        {
            ImportDAO.update(import);
        }

        public static void delete(Import import)
        {
            ImportDAO.delete(import);
        }

        public static void sumImport(Import import)
        {
            ImportDAO.sumCost(import);
        }

        public static List<Import> getAll()
        {
            return ImportDAO.getAll();
        }

 
    }
}
