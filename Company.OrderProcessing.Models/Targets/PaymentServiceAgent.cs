using Company.OrderProcessing.Models.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.Targets
{
    public class PaymentServiceAgent : Target
    {
        public PaymentServiceAgent(string description) : base(description)
        {
        }

        public override int Send(Output output)
        {
            Console.WriteLine("Sent payment details to " + Link);
            return 1;
        }
    }
}
