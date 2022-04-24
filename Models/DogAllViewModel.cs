using System;
using System.ComponentModel.DataAnnotations;

namespace DogsApp.Models
{
    public class DogAllViewModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Breed")]
        public string Breed { get; set; }

        [Display(Name = "Dog Picture")]
        public string Picture { get; set; }
    }
}
