using System;
using System.ComponentModel.DataAnnotations;

namespace Web_Assignment_2_To_Dos.Data
{
    public class To_Do
    {
        [Display(Name = "Done?", Description ="")]
        public bool Done { get; set; }

        [Display(Name = "To_Do Item", Description = "Enter the To_Do item")]
        [StringLength(255, MinimumLength = 2)]
        public string Name { get; set; }


        [Key]
        public DateTime EntryDate { get; set; } = DateTime.Now;
    }
}
