using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Dtos.Employee;
using WebApplication5.Models;
using WebApplication5.ViewModels;

namespace WebApplication5.Config
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(d => d.DepartmentName, opt => opt.MapFrom(x => x.Departmet.ToString()))
                //.ReverseMap()
            ;
            CreateMap<EmployeeDto, Employee>();

            CreateMap<EmployeeDto, HomeDetailsViewModel>()
                 .ForMember(d => d.Employee, opt => opt.MapFrom(x => x))
                 .ForMember(d => d.PageTitle, opt => opt.MapFrom(x => "EmplyeeDetails"))
                 ;



        }
    }
}
