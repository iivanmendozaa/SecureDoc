using AutoMapper;
using SecureDoc.Infrastructure.Models.Audit;
using SecureDoc.Application.Responses.Audit;

namespace SecureDoc.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}