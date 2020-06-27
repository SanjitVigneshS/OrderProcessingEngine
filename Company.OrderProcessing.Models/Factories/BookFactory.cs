using Company.OrderProcessing.Models.AbstractClasses;
using Company.OrderProcessing.Models.Outputs;
using Company.OrderProcessing.Models.Products;
using Company.OrderProcessing.Models.Targets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.Factories
{
    public class BookFactory : ProductFactory
    {
        public override Product Create(string description)
        {
            Target shippingClient = new ShippingAgent("Shipping");
            shippingClient.Link = "URL to Shipping Service";
            Target royaltyClient = new RoyaltyDepartmentClient("Royalty Department");
            royaltyClient.Link = "URL to Royalty Department Service";

            Product book = new Book(description);

            book.Outputs = new List<PackingSlip>();
            book.Outputs.Add(new PackingSlip("Original Packing Slip", book, shippingClient));
            book.Outputs.Add(new PackingSlip("Duplicate Packing Slip", book, royaltyClient));

            return book;
        }
    }
}
