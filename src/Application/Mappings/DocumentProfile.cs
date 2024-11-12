using AutoMapper;
using SecureDoc.Application.Features.Documents.Commands.AddEdit;
using SecureDoc.Application.Features.Documents.Queries.GetById;
using SecureDoc.Domain.Entities.Misc;

namespace SecureDoc.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}