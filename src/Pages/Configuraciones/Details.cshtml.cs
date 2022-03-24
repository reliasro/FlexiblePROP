using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Pages.Configuraciones
{
    public class DetailsModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;
        [BindProperty(SupportsGet = true)]
        public string UrlOrigen { get; set; }


        public DetailsModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        public Configuracion Configuracion { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UrlOrigen = HttpContext.Request.Headers["Referer"];
            if (id == null)
            {
                return NotFound();
            }

            Configuracion = await _context.Configuraciones.FirstOrDefaultAsync(m => m.ID == id);

            if (Configuracion == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
