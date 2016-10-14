using System;

namespace OrderLineExample
{
    public class Order
    {
        public DateTime DeliveryDate { get; set; }
        public DateTime OrderDate { get; set; }

        public bool Picked { get; set; }
        public int Id { get; set; }
    }
}