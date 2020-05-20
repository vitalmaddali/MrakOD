using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessor.Business.Core
{
    public class OrderFactory
    {


        public List<Order> GenerateOrders()
        {
            List<Order> orderList = new List<Order>();
            Order orderMem = new OrderMembership();
            Order ordervideo = new OrderVideo();
            Order orderPhysical = new OrderPhysicalProduct();
            
            orderList.Add(orderMem);
            orderList.Add(orderPhysical);
            orderList.Add(ordervideo);

            return orderList;

        }

        public bool ProcessAllOrder()
        {
            try
            {
                List<Order> orderList = GenerateOrders();

                foreach (Order item in orderList)
                {
                    item.ProcessOrder();
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        
    }
}