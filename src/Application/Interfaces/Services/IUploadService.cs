using SecureDoc.Application.Requests;

namespace SecureDoc.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}