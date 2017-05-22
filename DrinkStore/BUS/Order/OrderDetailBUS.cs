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

        public static void update(OrderDetail detail)
        {
            OrderDetailDAO.update(detail);
        }

        public static void delete(OrderDetail detail)
        {
            OrderDetailDAO.delete(detail);
        }
    }
}
