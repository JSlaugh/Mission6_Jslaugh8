using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_jslaugh8.Models
{
    public class FormResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "You must enter a category name like Sci-fi")]
        [Display(Name = "Category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "You must enter a Title name like The Martian")]
        [Display(Name = "Category")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The field Year must be greater than 1850")]
        [Range(1850,int.MaxValue,ErrorMessage = "The field Year must be greater than 1850")]
        [Display(Name ="Year")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "You must enter a Director's name")]
        [Display(Name = "Director")]
        public string Director { get; set; }
        [Required(ErrorMessage = "You must enter a Rating from the dropdown menu")]
        [Display(Name = "Director")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }
        [StringLength(25,ErrorMessage ="You are limited to 25 characters")]
        public string Notes { get; set; }
    }
}
