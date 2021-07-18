using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
            .ForMember(p => p.ProductBrand, q => q.MapFrom(s => s.ProductBrand.Name))
            .ForMember(p => p.ProductType, q => q.MapFrom(s => s.ProductType.Name))
            .ForMember(p => p.PictureUrl, q => q.MapFrom<ProductUrlResolver>());
        }
    }
}