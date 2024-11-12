using SecureDoc.Application.Interfaces.Repositories;
using SecureDoc.Domain.Entities.Catalog;

namespace SecureDoc.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}