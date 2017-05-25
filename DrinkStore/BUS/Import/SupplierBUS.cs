using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.DAO;
using DrinkStore.Entities;

namespace DrinkStore.BUS
{
    class SupplierBUS
    {
        public static List<Supplier> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Suppliers.ToList();
            }
        }
        public static Supplier getById(int id)
        {
            return SupplierDAO.getById(id);
        }

        public static bool add(Supplier supplier)
        {
            try
            {
                SupplierDAO.add(supplier);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool update(Supplier supplier)
        {
            try
            {
                SupplierDAO.update(supplier);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
