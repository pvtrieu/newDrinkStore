using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;
using DrinkStore.DAO;

namespace DrinkStore.BUS
{
    class BrandBUS
    {
        public static List<Brand> getAll()
        {
            return BrandDAO.getAll();
        }

        public static Brand getById(int id)
        {
            return BrandDAO.getById(id);
        }

        public static void insert(Brand brand)
        {
            BrandDAO.insert(brand);
        }

        public static void update(Brand brand)
        {
            BrandDAO.update(brand);
        }
    }
}
