using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessor.Business.Core
{
    public class OrderVideo : Order
    {
        public bool IsVideoForSki { get; set; }

        public override void ProcessOrder()
        {
            if (IsVideoForSki)
            {
                Console.WriteLine("add a free “First Aid” video to the packing slip (the result of a court decision in 1997)");
            }
            
        }
    }
}