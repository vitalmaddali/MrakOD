using OrderProcessor.Business.Core;
using System;

namespace OrderProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderFactory factory = new OrderFactory();
            factory.ProcessAllOrder();

            Console.ReadLine();
        }
    }
}
