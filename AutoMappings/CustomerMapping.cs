using AutoMapper;
using AutoMapping.Store.Entities;
using AutoMapping.Store.ViewModels;

namespace AutoMapping.Store.AutoMappings;

public class CustomerMapping : Profile
{
    public CustomerMapping()
    {
        CreateMap<Customer, CustomerViewModel>();
        CreateMap<CustomerViewModel, Customer>();
    }
}