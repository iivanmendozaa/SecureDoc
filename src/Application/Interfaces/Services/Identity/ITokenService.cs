using SecureDoc.Application.Interfaces.Common;
using SecureDoc.Application.Requests.Identity;
using SecureDoc.Application.Responses.Identity;
using SecureDoc.Shared.Wrapper;
using System.Threading.Tasks;

namespace SecureDoc.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}