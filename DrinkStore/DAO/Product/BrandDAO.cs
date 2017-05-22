using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class BrandDAO
    {
        public static List<Brand> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Brands.ToList();
            }
        }
        public static Brand getById(int id)
        {
            using (DSModel model = new DSModel())
            {
                return model.Brands.Find(id);
            }
        }

        public static void insert(Brand brand)
        {
            using (DSModel model = new DSModel())
            {
                model.Brands.Add(brand);
                model.SaveChanges();
            }
        }

        public static void update(Brand brand)
        {
            using (DSModel model = new DSModel())
            {
                var updateBrand = model.Brands.Find(brand.BrandID);
                model.Entry(updateBrand).CurrentValues.SetValues(brand);
                model.SaveChanges();
            }
        }
    }
}
