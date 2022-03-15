using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Dtos.Employee;
using WebApplication5.Models;

namespace WebApplication5.ViewModels
{
    public class HomeDetailsViewModel
    {
        public EmployeeDto Employee { get; set; }
        public String PageTitle { get; set; }
    }
}
