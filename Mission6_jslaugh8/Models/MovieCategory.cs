using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_jslaugh8.Models
{
    public class MovieCategory
    {

        [Key]
        [Required]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "You must enter a Title name like The Martian")]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }

    }
}
