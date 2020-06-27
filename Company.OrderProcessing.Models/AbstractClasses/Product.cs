using Company.OrderProcessing.Models.Outputs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.AbstractClasses
{
    public abstract class Product
    {
        public string Description { get; set; }

        public List<Output> Outputs { get; set; }

        internal Product(string description)
        {
            Description = description;
        }

        public virtual int ProcessOutputs()
        {
            int result = 0;
            foreach (PackingSlip output in Outputs)
            {
                Console.WriteLine("Sending " + output.Description + " for " + Description);
                result += output.SendToTarget();
            }
            return result;
        }
    }
}
