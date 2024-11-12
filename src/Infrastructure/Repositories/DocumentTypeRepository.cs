using SecureDoc.Application.Interfaces.Repositories;
using SecureDoc.Domain.Entities.Misc;

namespace SecureDoc.Infrastructure.Repositories
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly IRepositoryAsync<DocumentType, int> _repository;

        public DocumentTypeRepository(IRepositoryAsync<DocumentType, int> repository)
        {
            _repository = repository;
        }
    }
}