using AutoMapper;
using SysChief.Application.ViewModels;
using SysChief.Domain.Models;

namespace SysChief.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
        }
    }
}
