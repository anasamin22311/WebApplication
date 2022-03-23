using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.ViewModels
{
    public class EmployeeCreateViewModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "enter the mail plz")]
        //[RegularExpression("@^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$")]
        public string Email { get; set; }
        [Required]
        public Dept Department { get; set; }
        public List<IFormFile> Photos { get; set; }
    }
}
