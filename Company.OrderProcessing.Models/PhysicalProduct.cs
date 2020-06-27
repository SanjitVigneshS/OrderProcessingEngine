using System;
using System.Collections.Generic;

namespace Company.OrderProcessing.Models
{
    public class PhysicalProduct
    {
        public string Description { get; set; }

        public List<PackingSlip> Outputs { get; set; }

        public PhysicalProduct(string description)
        {
            this.Description = description;
        }

        public int ProcessOutput()
        {
            int result = 0;
            foreach(PackingSlip output in Outputs)
            {
                Console.WriteLine("Sending " + output.Description + " for " + Description);
                result += output.SendToTarget();
            }
            return result;
        }
    }
}
