using Company.OrderProcessing.Models.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.Outputs
{
    public class AgentCommission : Output
    {
        public AgentCommission(string description, Product product, Target target) : base(description, product, target)
        {
        }

        public override int SendToTarget()
        {
            return base.SendToTarget();
        }
    }
}
