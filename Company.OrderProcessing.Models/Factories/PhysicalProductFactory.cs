using Company.OrderProcessing.Models.AbstractClasses;
using Company.OrderProcessing.Models.Outputs;
using Company.OrderProcessing.Models.Products;
using Company.OrderProcessing.Models.Targets;
using System.Collections.Generic;

namespace Company.OrderProcessing.Models.Factories
{
    public class PhysicalProductFactory : ProductFactory
    {
        public override Product Create(string description)
        {
            Target client = new ShippingAgent("Shipping");
            client.Link = "URL to Shipping Service";
            Target paymentClient = new PaymentServiceAgent("Payment");
            paymentClient.Link = "URL to Payment Services";

            Product physicalProduct = new PhysicalProduct(description);
            physicalProduct.Outputs = new List<PackingSlip>();
            physicalProduct.Outputs.Add(new PackingSlip("Original Packing Slip", physicalProduct, client));
            physicalProduct.Outputs.Add(new PackingSlip("Commission Payment", physicalProduct, paymentClient));

            return physicalProduct;
        }
    }
}
