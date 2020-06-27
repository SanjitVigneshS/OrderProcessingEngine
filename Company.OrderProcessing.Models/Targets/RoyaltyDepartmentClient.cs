using Company.OrderProcessing.Models.AbstractClasses;
using Company.OrderProcessing.Models.Outputs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.Targets
{
    public class RoyaltyDepartmentClient: Target
    {
        public RoyaltyDepartmentClient(string description) : base(description)
        {
        }
        public override int Send(Output slip)
        {
            Console.WriteLine(slip.Description + " sent to " + Link);
            //Console.WriteLine("Product: " + slip.Product.Description);
            return 0;
        }
    }
}
