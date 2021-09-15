using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEmptyWebApplicationCore.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name no puede exceder los 50 caracteres")]
        public string Nombre { get; set; }

        //Navigation
        public List<Book> Books { get; set; }
    }
}
