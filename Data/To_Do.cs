using System;
using System.ComponentModel.DataAnnotations;

namespace Web_Assignment_2_To_Dos.Data
{
    public class To_Do
    {
        public bool Done { get; set; }

        [StringLength(255, MinimumLength = 1)]
        public string Name { get; set; }

        public DateTime EntryDate { get; set; } = DateTime.Now;
    }
}
