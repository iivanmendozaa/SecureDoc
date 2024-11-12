using AutoMapper;
using SecureDoc.Application.Features.Products.Commands.AddEdit;
using SecureDoc.Domain.Entities.Catalog;

namespace SecureDoc.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}