using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class ProductDAO
    {
        public static Product getByID(int productID)
        {
            using (DSModel model = new DSModel())
            {
                return model.Products.Find(productID);
            }
        }
        public static void add(Product product)
        {
            using (DSModel model = new DSModel())
            {
                model.Products.Add(product);
                model.SaveChanges();
            }
        }

        public static void update(Product product)
        {
            using (DSModel model = new DSModel())
            {
                var updateProduct = model.Products.Find(product.ProductID);
                model.Entry(updateProduct).CurrentValues.SetValues(product);
                model.SaveChanges();
            }
        }

        public static void delete(Product product)
        {
            using (DSModel model = new DSModel())
            {
                var delProduct = model.Products.Find(product.ProductID);
                model.Products.Remove(delProduct);
                model.SaveChanges();
            }
        }

        public static List<Product> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Products.ToList();
            }
        }

        public static List<Product> search(string name, int? cateID, int? brandID)
        {
            using (DSModel model = new DSModel())
            {
                var result = model.Products.ToList();
                if (!String.IsNullOrEmpty(name))
                    result = result.Where(x => x.Name.Contains(name)).ToList();
                if (cateID != null)
                    result = result.Where(x => x.CategoryID == cateID).ToList();
                if (brandID != null)
                    result = result.Where(x => x.BrandID == brandID).ToList();

                return result;
            }
        }

        public static decimal? maxUnitCost (Product product)
        {
            using(DSModel model = new DSModel())
            {
                return model.ImportDetails.Where(x => x.ProductID == product.ProductID).Max(x => x.UnitCost);
            }
        }
    }
}
