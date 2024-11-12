using System.Collections.Generic;
using System.Threading.Tasks;
using SecureDoc.Application.Features.DocumentTypes.Commands.AddEdit;
using SecureDoc.Application.Features.DocumentTypes.Queries.GetAll;
using SecureDoc.Shared.Wrapper;

namespace SecureDoc.Client.Infrastructure.Managers.Misc.DocumentType
{
    public interface IDocumentTypeManager : IManager
    {
        Task<IResult<List<GetAllDocumentTypesResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditDocumentTypeCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}