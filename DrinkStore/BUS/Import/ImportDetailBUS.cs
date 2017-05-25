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

       

        public static bool add(ImportDetail detail)
        {
            try
            {
                ImportDetailDAO.add(detail);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public static bool update(ImportDetail detail)
        { 
            try
            {
                ImportDetailDAO.update(detail);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public static bool delete(ImportDetail detail)
        {
            try
            {
                ImportDetailDAO.delete(detail);
                return true;
            }
            catch
            {
                return false;
            }
        
        }
    }
}
