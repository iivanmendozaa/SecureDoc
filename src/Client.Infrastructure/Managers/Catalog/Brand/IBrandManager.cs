using SecureDoc.Application.Features.Brands.Queries.GetAll;
using SecureDoc.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using SecureDoc.Application.Features.Brands.Commands.AddEdit;

namespace SecureDoc.Client.Infrastructure.Managers.Catalog.Brand
{
    public interface IBrandManager : IManager
    {
        Task<IResult<List<GetAllBrandsResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditBrandCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}