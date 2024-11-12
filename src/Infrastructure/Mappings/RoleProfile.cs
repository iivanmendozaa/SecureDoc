using AutoMapper;
using SecureDoc.Infrastructure.Models.Identity;
using SecureDoc.Application.Responses.Identity;

namespace SecureDoc.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, SecureDocRole>().ReverseMap();
        }
    }
}