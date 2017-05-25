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

        public static bool add(Brand brand)
        {
            try
            {          
                BrandDAO.add(brand);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public static bool update(Brand brand)
        {
            try
            {
                BrandDAO.update(brand);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
