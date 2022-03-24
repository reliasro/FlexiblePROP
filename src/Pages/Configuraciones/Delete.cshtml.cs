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
    public class DeleteModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public DeleteModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Configuracion Configuracion { get; set; }
        
        //Este valor es enviado via URL
        [BindProperty(SupportsGet = true)]
        public string UrlOrigen { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            ViewData["Origen"] = HttpContext.Request.Headers["Referer"];
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
          /*  if (id == null)
            {
                return NotFound();
            }

            Configuracion = await _context.Configuraciones.FindAsync(id);
          */
            if (Configuracion != null)
            {
                _context.Configuraciones.Remove(Configuracion);
                await _context.SaveChangesAsync();
            }

            return Redirect(UrlOrigen);
        }
    }
}
