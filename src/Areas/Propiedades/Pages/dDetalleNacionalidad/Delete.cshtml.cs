using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dDetalleNacionalidad
{
    public class DeleteModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public DeleteModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DetalleNacionalidad DetalleNacionalidad { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DetalleNacionalidad = await _context.DocumentosNacionales
                .Include(d => d.Cliente)
                .Include(d => d.Nacionalidad).FirstOrDefaultAsync(m => m.ClienteID == id);

            if (DetalleNacionalidad == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DetalleNacionalidad = await _context.DocumentosNacionales.FindAsync(id);

            if (DetalleNacionalidad != null)
            {
                _context.DocumentosNacionales.Remove(DetalleNacionalidad);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
