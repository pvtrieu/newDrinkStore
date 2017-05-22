using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class OrderDAO
    {
        public static List<Order> getAll()
        {
            using (DSModel model = new DSModel())
            {
                return model.Orders.ToList();
            }
        }

        public static void add(Order order)
        {
            using (DSModel model = new DSModel())
            {
                model.Orders.Add(order);
                model.SaveChanges();
            }
        }

        public static void update(Order order)
        {
            using (DSModel model = new DSModel())
            {
                var updateOrder = model.Orders.Find(order.OrderID);
                model.Entry(updateOrder).CurrentValues.SetValues(order);
                model.SaveChanges();
            }
        }

        public static void delete(Order order)
        {
            using (DSModel model = new DSModel())
            {
                var delOrder = model.Orders.Find(order.OrderID);
                model.Orders.Remove(delOrder);
                model.SaveChanges();
            }
        }

        public static void sumCost(Order order)
        {
            using (DSModel model = new DSModel())
            {
                var sumOrder = model.Orders.Find(order.OrderID);
                order.TotalCost = model.OrderDetails.Where(x => x.OrderID == order.OrderID).
                                                                Sum(x => x.UnitCost * x.Amount);
                model.Entry(sumOrder).CurrentValues.SetValues(order);
                model.SaveChanges();
            }
        }

    }
}
