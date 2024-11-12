using SecureDoc.Application.Interfaces.Common;

namespace SecureDoc.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}