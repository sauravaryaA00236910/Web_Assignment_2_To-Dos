using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web_Assignment_2_To_Dos.Data;

namespace Web_Assignment_2_To_Dos.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (ModelState.IsValid)
            {

            }
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {

            } 
        }

        [FromForm]
        public To_Do To_Do { get; set; }
    }
}
