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

        public static void insert (Category category)
        {
            CategoryDAO.insert(category);
        }

        public static void update (Category category)
        {
            CategoryDAO.update(category);
        }
    }
}
