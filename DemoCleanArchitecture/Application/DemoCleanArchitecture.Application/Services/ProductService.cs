using DemoCleanArchitecture.Domain.Interfaces;
using DemoCleanArchitecture.Domain.Interfaces.Services;
using DemoCleanArchitecture.Domain.Models;
using DemoCleanArchitecture.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCleanArchitecture.Application.Services
{
    public class ProductService : IProductService
    {
        readonly ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product Get(int productId)
        {
            try
            {
                Product product =  _productRepository.Find(x => x.ProductId == productId).Include(x=>x.Type).FirstOrDefault();
                return product;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Post(Product product)
        {
            try
            {
                _productRepository.Add(product);
                _productRepository.Save();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }
    }
}
