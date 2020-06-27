using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models
{
    public class ShippingClient
    {
        public string Description { get; set; }
        public string Link { get; set; }
        public ShippingClient(string description)
        {
            Description = description;
        }
        public int Send(PackingSlip slip)
        {
            Console.WriteLine(slip.Description + " sent to " + Link);
            Console.WriteLine("Product: " + slip.Product.Description);
            return 0;
        }
    }
}
