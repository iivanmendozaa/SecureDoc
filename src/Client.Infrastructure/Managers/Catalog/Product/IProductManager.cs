using SecureDoc.Application.Features.Products.Commands.AddEdit;
using SecureDoc.Application.Features.Products.Queries.GetAllPaged;
using SecureDoc.Application.Requests.Catalog;
using SecureDoc.Shared.Wrapper;
using System.Threading.Tasks;

namespace SecureDoc.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}