using Company.OrderProcessing.Models.AbstractClasses;
using Company.OrderProcessing.Models.Outputs;
using Company.OrderProcessing.Models.Products;
using Company.OrderProcessing.Models.Targets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.Factories
{
    public class MembershipFactory: ProductFactory
    {
        public override Product Create(string description)
        {
            Target userServiceAgent = new UserServiceAgent("User Agent");
            userServiceAgent.Link = "URL to Shipping Service";
            Target emailClient = new EmailClient("Email");
            emailClient.Link = "URL to Royalty Department Service";

            Product membership = new Membership(description);

            membership.Outputs = new List<Output>();
            membership.Outputs.Add(new PackingSlip("Membership Change", membership, userServiceAgent));
            membership.Outputs.Add(new PackingSlip("Membership Change", membership, emailClient));

            return membership;
        }
    }
}
