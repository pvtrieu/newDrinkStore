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
        public static bool add(Import import)
        {
            try
            {
                ImportDAO.add(import);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public static bool update(Import import)
        {
            try
            {
                ImportDAO.update(import);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

     

        public static bool delete(Import import)
        {
            try
            {
                ImportDAO.delete(import);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public static void sumImport(Import import)
        {
            ImportDAO.sumCost(import);
        }

        public static List<Import> getAll(Staff staff)
        {
            return ImportDAO.getAll(staff);
        }

        public static List<Import> search(int? supplierID, DateTime? after, DateTime? before)
        {
            return ImportDAO.search(supplierID, after, before);
        }



    }
}
