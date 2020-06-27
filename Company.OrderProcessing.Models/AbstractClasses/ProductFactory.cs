using System;
using System.Collections.Generic;
using System.Text;

namespace Company.OrderProcessing.Models.AbstractClasses
{
    /// <summary>
    /// The base factory class which will be where
    /// product factory classes be based on 
    /// for product instance creation.
    /// The implementations will set the necessary
    /// properties in the product for the order engine
    /// to process.
    /// </summary>
    public abstract class ProductFactory
    {
        public abstract Product Create(string description);
    }
}
