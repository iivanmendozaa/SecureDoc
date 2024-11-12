using AutoMapper;
using SecureDoc.Application.Features.Brands.Commands.AddEdit;
using SecureDoc.Application.Features.Brands.Queries.GetAll;
using SecureDoc.Application.Features.Brands.Queries.GetById;
using SecureDoc.Domain.Entities.Catalog;

namespace SecureDoc.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}