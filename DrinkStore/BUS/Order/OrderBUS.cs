using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;
using DrinkStore.DAO;

namespace DrinkStore.BUS
{
    class OrderBUS
    {
        public static List<Order> getAll()
        {
            return OrderDAO.getAll();
        }

        public static void add(Order order)
        {
            OrderDAO.add(order);
        }

        public static void update(Order order)
        {
            OrderDAO.update(order);
        }

        public static void delete(Order order)
        {
            OrderDAO.delete(order);
        }

        public static void sumOrder(Order order)
        {
            OrderDAO.sumCost(order);
        }
    }
}
