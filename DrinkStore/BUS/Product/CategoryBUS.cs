using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;
using DrinkStore.DAO;

namespace DrinkStore.BUS
{
    class CategoryBUS
    {
        

        public static List<Category> getAll()
        {
            return CategoryDAO.getAll();
        }

        public static Category getById(int id)
        {
            return CategoryDAO.getById(id);
        }

        public static bool add (Category category)
        {
            try
            {
                CategoryDAO.add(category);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public static bool update (Category category)
        {
            try
            {
                CategoryDAO.update(category);
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
