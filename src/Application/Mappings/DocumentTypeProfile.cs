using AutoMapper;
using SecureDoc.Application.Features.DocumentTypes.Commands.AddEdit;
using SecureDoc.Application.Features.DocumentTypes.Queries.GetAll;
using SecureDoc.Application.Features.DocumentTypes.Queries.GetById;
using SecureDoc.Domain.Entities.Misc;

namespace SecureDoc.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}