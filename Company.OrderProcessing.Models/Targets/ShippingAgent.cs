﻿using Company.OrderProcessing.Models.AbstractClasses;
using Company.OrderProcessing.Models.Outputs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.Targets
{
    public class ShippingAgent: Target
    {
        public ShippingAgent(string description): base(description)
        {
        }
        public override int Send(Output slip)
        {
            Console.WriteLine(slip.Description + " sent to " + Link);
            foreach(Product product in slip.Products)
            {
                Console.WriteLine("Product: " + product.Description);
            }
            return 1;
        }
    }
}
