using System;

namespace OrderProcessor.Business.Core
{
    public abstract class Order
    {
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public double OrderTotal { get; set; }
        public virtual void ProcessOrder()
        {

        }
    }
}
