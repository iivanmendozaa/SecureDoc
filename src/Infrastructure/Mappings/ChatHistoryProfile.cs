using AutoMapper;
using SecureDoc.Application.Interfaces.Chat;
using SecureDoc.Application.Models.Chat;
using SecureDoc.Infrastructure.Models.Identity;

namespace SecureDoc.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}