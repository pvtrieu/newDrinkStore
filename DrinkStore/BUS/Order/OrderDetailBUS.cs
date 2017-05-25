using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;
using DrinkStore.DAO;

namespace DrinkStore.BUS
{
    class OrderDetailBUS
    {
        public static List<OrderDetail> getAll(Order order)
        {
            return OrderDetailDAO.getAll(order);
        }

        public static bool available(int productID, int? amount)
        {
            int? inStock = OrderDetailDAO.inStock(productID);
            int? outStock = OrderDetailDAO.outStock(productID);
            if (inStock == null) inStock = 0;
            if (outStock == null) outStock = 0;
            if (inStock - outStock >= amount)
                return true;
            else
                return false;
        }

        public static bool add(OrderDetail detail)
        {
            try
            {
                OrderDetailDAO.add(detail);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool update(OrderDetail detail)
        {
            try
            {
                OrderDetailDAO.update(detail);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool delete(OrderDetail detail)
        {
            try
            {
                OrderDetailDAO.delete(detail);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
