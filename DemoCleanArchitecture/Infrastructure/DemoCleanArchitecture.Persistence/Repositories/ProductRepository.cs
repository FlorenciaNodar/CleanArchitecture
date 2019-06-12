using DemoCleanArchitecture.Persistence.Data;
using DemoCleanArchitecture.Domain.Models;

namespace DemoCleanArchitecture.Persistence.Repositories
{
    public class ProductRepository: GenericRepository<Product>
    {
        public ProductRepository(CleanArchitectureContext context):base(context)
        {

        }
    }
}
