using Company.OrderProcessing.Models.AbstractClasses;
using Company.OrderProcessing.Models.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.Factories
{
    public class BookFactory : ProductFactory
    {
        public override Product Create(string description)
        {
            Product book = new Book(description);
            return book;
        }
    }
}
