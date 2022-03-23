using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.ViewModels
{
    public class EmployeeEditViewModel : EmployeeCreateViewModel
    {
        internal string existingphotopath;

        public int ID { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
