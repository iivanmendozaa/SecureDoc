using AutoMapper;
using SecureDoc.Application.Requests.Identity;
using SecureDoc.Application.Responses.Identity;
using SecureDoc.Infrastructure.Models.Identity;

namespace SecureDoc.Infrastructure.Mappings
{
    public class RoleClaimProfile : Profile
    {
        public RoleClaimProfile()
        {
            CreateMap<RoleClaimResponse, SecureDocRoleClaim>()
                .ForMember(nameof(SecureDocRoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(SecureDocRoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();

            CreateMap<RoleClaimRequest, SecureDocRoleClaim>()
                .ForMember(nameof(SecureDocRoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(SecureDocRoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();
        }
    }
}