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

        public static void insert(Supplier supplier)
        {
            SupplierDAO.insert(supplier);
        }

        public static void update(Supplier supplier)
        {
            SupplierDAO.update(supplier);
        }
    }
}
