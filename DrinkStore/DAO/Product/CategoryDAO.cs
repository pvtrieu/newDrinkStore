using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class CategoryDAO
    {
        public  static List<Category> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Categories.ToList();
            }
        }

        public static Category getById(int id)
        {
            using (DSModel model = new DSModel())
            {
                return model.Categories.Find(id);
            }
        }

        public static void insert(Category category)
        {
            using (DSModel model = new DSModel())
            {
                model.Categories.Add(category);
                model.SaveChanges();
            }
        }

        public static void update(Category category)
        {
            using (DSModel model = new DSModel())
            {
                var updateCategory = model.Categories.Find(category.CategoryID);
                model.Entry(updateCategory).CurrentValues.SetValues(category);
                model.SaveChanges();
            }
        }
    }
}
