using Company.OrderProcessing.Models.AbstractClasses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.Targets
{
    public class UserServiceAgent : Target
    {
        public UserServiceAgent(string description) : base(description)
        {
        }
        public override int Send(Output output)
        {
            string userId = "123456"; //Get from authorization context.
            Console.WriteLine("POST to user service " + Link);
            MembershipChangeMessageBody body = new MembershipChangeMessageBody();
            body.UserId = userId;
            body.NewMembership = output.Products[0].Description;
            Console.WriteLine("POST Body: " + JsonConvert.SerializeObject(body));
            return 0;
        }
    }

    class MembershipChangeMessageBody
    {
        public string UserId { get; set; }
        public string NewMembership { get; set; }
    }
}
