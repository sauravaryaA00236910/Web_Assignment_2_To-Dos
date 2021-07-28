using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Assignment_2_To_Dos.Data
{
    public class To_Do
    {
        [Display(Name = "Done?", Description ="")]
        public bool Done { get; set; }
        
        [StringLength(255, MinimumLength = 1)]
        [Display(Name = "To_DoItem", Description = "Enter the To_Do item")]
        public string To_DoItem { get; set; }

        [Key]
        public DateTime EntryDate { get; set; } = DateTime.Now;
    }
}
