using DemoCleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;

namespace DemoCleanArchitecture.Domain.Model
{
    public partial class ProductType
    {
        public ProductType()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
