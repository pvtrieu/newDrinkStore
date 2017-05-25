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
        public static List<Order> getAll(Staff staff)
        {
            return OrderDAO.getAll(staff);
        }

        public static bool add(Order order)
        {
            try
            {
                OrderDAO.add(order);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool update(Order order)
        {
            try
            {
                OrderDAO.update(order);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool delete(Order order)
        {
            try
            {
                OrderDAO.delete(order);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static void sumOrder(Order order)
        {
            OrderDAO.sumCost(order);
        }

        public static List<Order> search(DateTime? after, DateTime? before)
        {
            return OrderDAO.search(after, before);
        }
    }
}
