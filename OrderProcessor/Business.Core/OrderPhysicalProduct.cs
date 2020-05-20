using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessor.Business.Core
{
    public class OrderPhysicalProduct : Order
    {
        public bool IsBook { get; set; }
        public override void ProcessOrder()
        {
            if (IsBook)
            {
                Console.WriteLine("create a duplicate packing slip for the royalty departme");
            }
            else
            {
                Console.WriteLine("Generated packing slip for shipping");
            }
            Console.WriteLine("Add Commission to agent");
        }
    }
}