using AutoMapper;
using SecureDoc.Infrastructure.Models.Identity;
using SecureDoc.Application.Responses.Identity;

namespace SecureDoc.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, SecureDocUser>().ReverseMap();
            CreateMap<ChatUserResponse, SecureDocUser>().ReverseMap()
                .ForMember(dest => dest.EmailAddress, source => source.MapFrom(source => source.Email)); //Specific Mapping
        }
    }
}