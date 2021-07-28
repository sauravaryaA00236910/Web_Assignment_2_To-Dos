using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web_Assignment_2_To_Dos.Data;
using Web_Assignment_2_To_Dos.Data.Context;

namespace Web_Assignment_2_To_Dos.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private To_DoContext _context{get;set;}

        public IEnumerable<To_Do> To_DoLog { get; set; }

        [FromQuery]
        public To_Do UpdateTo_do { get; set; }

        [FromForm]
        public To_Do To_do { get; set; }

        public IndexModel(ILogger<IndexModel> logger, To_DoContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            if(UpdateTo_do.To_DoItem !=null)
            {
                
                try
                {
                    _context.To_Dos.Update(UpdateTo_do);
                    _context.SaveChanges();
                }
                catch
                {
                    _context.To_Dos.Add(UpdateTo_do);
                    _context.SaveChanges();
                }
                
            }
            To_DoLog = _context.To_Dos.ToList();
        }
        public void OnPost()
        {
            if (!String.IsNullOrEmpty(To_do.To_DoItem))
            {
                _context.To_Dos.Add(To_do);
                _context.SaveChanges();
            }
            //else if (!String.IsNullOrEmpty(UpdateTo_do.To_DoItem))
            //{
            //    try
            //    {
            //        _context.To_Dos.Update(UpdateTo_do);
            //        _context.SaveChanges();
            //    }
            //    catch
            //    {
            //        _context.To_Dos.Add(UpdateTo_do);
            //        _context.SaveChanges();
            //    }

            //}
            To_DoLog = _context.To_Dos.ToList();
        }

        //[FromForm]
        //public To_Do To_Do { get; set; }
        //public object ModelState { get; private set; }
    }
}