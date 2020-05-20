using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessor.Business.Core
{
    public class OrderMembership : Order
    {
        public bool IsUpgrade { get; set; }
        public override void ProcessOrder()
        {
            if (IsUpgrade)
            {
                Console.WriteLine("apply the upgrade");
            }
            else
            {
                Console.WriteLine(" activate that membership");
            }
            Console.WriteLine("e - mail the owner and inform them of the activation/ upgrade");
        }
    }
}
