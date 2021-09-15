using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEmptyWebApplicationCore.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name no puede exceder los 50 caracteres")]
        public string FullName { get; set; }

        //Navigation
        public List<Book_Author> Book_Authors { get; set; }
    }
}
