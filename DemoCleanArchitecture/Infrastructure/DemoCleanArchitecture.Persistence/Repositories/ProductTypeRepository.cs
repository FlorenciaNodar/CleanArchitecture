using DemoCleanArchitecture.Persistence.Data;
using DemoCleanArchitecture.Domain.Model;

namespace DemoCleanArchitecture.Persistence.Repositories
{
    public class ProductTypeRepository : GenericRepository<ProductType>
    {
        public ProductTypeRepository(CleanArchitectureContext context):base(context)
        {

        }
    }
}
