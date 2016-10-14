using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLineExample
{
    public class OrderRepository : IOrderRepository
    {
        List<Order> listOfOrder;

        public OrderRepository()
        {
            Order o = new Order();
            o.Id = 1;
            Order o2 = new Order();
            o2.Id = 2;
            listOfOrder = new List<Order>();
            listOfOrder.Add(o);
            listOfOrder.Add(o2);

        }

        public void Add(Order order)
        {
            listOfOrder.Add(order);
        }

        public void ReceiveOrder(DateTime deliveryDate, DateTime orderDate)
        {
            int id = listOfOrder.Count;

            Order order = new Order();
            order.DeliveryDate = deliveryDate;
            order.OrderDate = orderDate;
            order.Picked = false;
            order.Id = id++;

        }
    }
}
