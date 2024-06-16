﻿using AutoMapper;
using OsDsII.api.Dtos.Customers;
using OsDsII.api.Dtos.ServiceOrders;
using OsDsII.api.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OsDsII.api
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping()
        {
            CreateMap<CreateCustomerDto, Customer>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<Customer, CustomerDto>();

            CreateMap<ServiceOrder, CreateServiceOrderDto>();
            CreateMap<CreateServiceOrderDto, ServiceOrder>();
            CreateMap<ServiceOrder, NewServiceOrderDto>();
            CreateMap<ServiceOrder, ServiceOrderDto>();
        }
    }
}