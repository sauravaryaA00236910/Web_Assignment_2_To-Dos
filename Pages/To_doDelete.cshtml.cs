using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Assignment_2_To_Dos.Data;
using Web_Assignment_2_To_Dos.Data.Context;

namespace Web_Assignment_2_To_Dos.Pages
{
    public class To_doDeleteModel : PageModel
    {
        To_DoContext _context;

        [FromQuery]
        public To_Do UpdateTo_do { get; set; }

        public To_doDeleteModel(To_DoContext context)
        {
            _context = context;
        }

        public RedirectToPageResult OnGet()
        {
            if(UpdateTo_do.To_DoItem != null)
            {
                _context.To_Dos.Remove(UpdateTo_do);
                _context.SaveChanges();

            }
            return new RedirectToPageResult("Index");
        }
    }
}
