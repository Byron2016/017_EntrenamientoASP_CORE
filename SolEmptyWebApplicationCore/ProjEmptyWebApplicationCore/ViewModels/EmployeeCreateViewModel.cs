using Microsoft.AspNetCore.Http;
using ProjEmptyWebApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEmptyWebApplicationCore.ViewModels
{
    public class EmployeeCreateViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Name no puede exceder los 50 caracteres")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }
        [Display(Name = "Pertenece a")]
        [Required]
        public Dept? Department { get; set; }
        public  List<IFormFile> Photos { get; set; }
    }
}
