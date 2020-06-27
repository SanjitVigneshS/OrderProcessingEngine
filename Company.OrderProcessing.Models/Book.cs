using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models
{
    public class Book
    {
        public string Description { get; set; }

        List<PackingSlip> Outputs { get; set; }

        internal Book(string description)
        {
            this.Description = description;
        }

        public int ProcessOutput()
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
