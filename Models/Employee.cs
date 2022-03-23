using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="enter the mail plz")]
        //[RegularExpression("@^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$")]
        public string Email { get; set; }
        [Required]
        public Dept Departmet { get; set; }
        public string PhotoPath { get; set; }
        


    }
}
