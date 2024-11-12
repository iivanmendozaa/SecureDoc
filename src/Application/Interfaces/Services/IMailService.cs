using SecureDoc.Application.Requests.Mail;
using System.Threading.Tasks;

namespace SecureDoc.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}