using SecureDoc.Shared.Wrapper;
using System.Threading.Tasks;
using SecureDoc.Application.Features.Dashboards.Queries.GetData;

namespace SecureDoc.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}