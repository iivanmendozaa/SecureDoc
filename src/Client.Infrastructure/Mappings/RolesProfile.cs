using AutoMapper;
using SecureDoc.Application.Requests.Identity;
using SecureDoc.Application.Responses.Identity;

namespace SecureDoc.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}