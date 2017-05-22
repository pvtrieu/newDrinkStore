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
        public static void insert(Product product)
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
                return model.Products.Where(x => x.Name.Contains(name)
                                            || x.CategoryID == cateID
                                            || x.BrandID == brandID)
                                            .ToList();
            }
        }

        public static int? inStock(int productID)
        {
            using (DSModel model = new DSModel())
            {
                return model.ImportDetails.Where(x => x.ProductID == productID)
                                          .Sum(x => x.Amount);
            }
        }

        public static int? outStock(int productID)
        {
            using (DSModel model = new DSModel())
            {
                return model.OrderDetails.Where(x => x.ProductID == productID)
                                          .Sum(x => x.Amount);
            }
        }
    }
}
