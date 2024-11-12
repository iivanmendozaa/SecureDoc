using SecureDoc.Application.Interfaces.Common;
using SecureDoc.Application.Requests.Identity;
using SecureDoc.Shared.Wrapper;
using System.Threading.Tasks;

namespace SecureDoc.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}