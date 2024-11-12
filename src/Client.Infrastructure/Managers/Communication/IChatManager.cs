using SecureDoc.Application.Models.Chat;
using SecureDoc.Application.Responses.Identity;
using SecureDoc.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using SecureDoc.Application.Interfaces.Chat;

namespace SecureDoc.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}