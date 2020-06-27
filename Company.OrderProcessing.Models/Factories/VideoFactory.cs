using Company.OrderProcessing.Models.AbstractClasses;
using Company.OrderProcessing.Models.Outputs;
using Company.OrderProcessing.Models.Products;
using Company.OrderProcessing.Models.Targets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.Factories
{
    public class VideoFactory : ProductFactory
    {
        public override Product Create(string description)
        {
            Target client = new ShippingAgent("Shipping");
            client.Link = "URL to Shipping Service";

            Product video = new Video(description);

            video.Outputs = new List<Output>();
            video.Outputs.Add(new VideoPackingSlip("Original Packing Slip", video, client));

            return video;
        }
    }
}
