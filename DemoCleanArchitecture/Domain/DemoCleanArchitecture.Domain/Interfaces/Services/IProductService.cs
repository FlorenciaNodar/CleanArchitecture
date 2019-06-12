using DemoCleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCleanArchitecture.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Product Get(int productId);
        void Post(Product product);
    }
}
