using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.DAO;
using DrinkStore.Entities;

namespace DrinkStore.BUS
{
    class ProductBUS
    {
        public static Product getByID(int productID)
        {
            return ProductDAO.getByID(productID);
        }
        public static bool add(Product product)
        {
            try
            {
                ProductDAO.add(product);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool update(Product product)
        {
            try
            {
                ProductDAO.update(product);
                return true;
            }
            catch
            {
                return false;
            }
           
        }

        public static bool delete(Product product)
        {
            try
            {
                ProductDAO.delete(product);
                return true;
            }
            catch
            {
                return false;
            }
           
        }

        public static List<Product> getAll()
        {
            return ProductDAO.getAll();
        }

        public static List<Product> search(string name, int? cateID, int? brandID)
        { 
            return ProductDAO.search(name, cateID, brandID);
        }

        public static bool available(int productID, int? amount)
        {
            int? inStock = ProductDAO.inStock(productID);
            int? outStock = ProductDAO.outStock(productID);
            if (inStock == null) inStock = 0;
            if (outStock == null) outStock = 0;
            if (inStock - outStock >= amount)
                return true;
            else
                return false;
        }
    }
}
