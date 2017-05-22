using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class SupplierDAO
    {
        public static Supplier getById(int id)
        {
            using (DSModel model = new DSModel())
            {
                return model.Suppliers.Find(id);
            }
        }

        public static void insert(Supplier supplier)
        {
            using (DSModel model = new DSModel())
            {
                model.Suppliers.Add(supplier);
                model.SaveChanges();
            }
        }

        public static void update(Supplier supplier)
        {
            using (DSModel model = new DSModel())
            {
                var updateSupplier = model.Suppliers.Find(supplier.SupplierID);
                model.Entry(updateSupplier).CurrentValues.SetValues(supplier);
                model.SaveChanges();
            }
        }

        public static void delete(Supplier supplier)
        {
            using (DSModel model = new DSModel())
            {
                var delSupplier = model.Suppliers.Find(supplier.SupplierID);
                model.Suppliers.Remove(delSupplier);
                model.SaveChanges();
            }
        }

        public static List<Supplier> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Suppliers.ToList();
            }
        }
    }
}
