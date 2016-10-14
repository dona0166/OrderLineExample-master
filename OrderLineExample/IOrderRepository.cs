using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLineExample
{
    public interface IOrderRepository
    {

        void ReceiveOrder(DateTime deliveryDate, DateTime orderDate);
        void Add(Order order);
    }
}
