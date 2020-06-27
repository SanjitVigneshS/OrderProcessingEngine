using Company.OrderProcessing.Models.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.Targets
{
    public class EmailClient : Target
    {
        public EmailClient(string description) : base(description)
        {
        }
        public override int Send(Output email)
        {
            Console.WriteLine(email.Description + " notification sent to email " + Link);
            return 0;
        }
    }
}
