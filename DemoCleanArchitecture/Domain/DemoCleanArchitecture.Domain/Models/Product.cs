using DemoCleanArchitecture.Domain.Model;
using System;
using System.Collections.Generic;

namespace DemoCleanArchitecture.Domain.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public int TypeId { get; set; }
        public string Description { get; set; }

        public virtual ProductType Type { get; set; }
    }
}
