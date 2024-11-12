using System.Collections.Generic;
using System.Threading.Tasks;
using SecureDoc.Application.Requests.Identity;
using SecureDoc.Application.Responses.Identity;
using SecureDoc.Shared.Wrapper;

namespace SecureDoc.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}