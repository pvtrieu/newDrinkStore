using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkStore.Entities;

namespace DrinkStore.DAO
{
    class OrderDetailDAO
    {
        public static List<OrderDetail> getAll(Order order)
        {
            using (DSModel model = new DSModel())
            {
                return model.OrderDetails.Where(x => x.OrderID == order.OrderID).ToList();
            }
        }

        public static void add(OrderDetail orderDetail)
        {
            using (DSModel model = new DSModel())
            {                
                model.OrderDetails.Add(orderDetail);
                model.SaveChanges();
            }
        }

        public static void update(OrderDetail detail)
        {
            using (DSModel model = new DSModel())
            {
                var updateOrderDetail = model.OrderDetails.Find(detail.OrderID, detail.ProductID);
                model.Entry(updateOrderDetail).CurrentValues.SetValues(detail);
                model.SaveChanges();
            }
        }

        public static void delete(OrderDetail detail)
        {
            using (DSModel model = new DSModel())
            {
                var delOrderDetail = model.OrderDetails.Find(detail.OrderID, detail.ProductID);
                model.OrderDetails.Remove(delOrderDetail);
                model.SaveChanges();
            }
        }
    }
}
