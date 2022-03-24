using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dPropiedad
{
    public class DeleteModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public DeleteModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Propiedad Propiedad { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Propiedad = await _context.Propiedades
                .Include(p => p.EstadoPropiedad)
                .Include(p => p.MonedaValores)
                .Include(p => p.TipoPropiedad)
                .Include(p => p.UnidadEspacio)
                .Include(p => p.Vendedor).FirstOrDefaultAsync(m => m.ID == id);

            if (Propiedad == null)
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

            Propiedad = await _context.Propiedades.FindAsync(id);

            if (Propiedad != null)
            {
                _context.Propiedades.Remove(Propiedad);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
