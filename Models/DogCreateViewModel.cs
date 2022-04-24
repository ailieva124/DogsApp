using System;
using System.ComponentModel.DataAnnotations;

namespace DogsApp.Models
{
    public class DogCreateViewModel
    {
        [Required]
        [MaxLength(30)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Range(1, 30, ErrorMessage = "Age must be a positive number and lower than 30")]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Breed")]
        public string Breed { get; set; }

        [Display(Name = "Dog Picture")]
        public string Picture { get; set; }
    }
}
