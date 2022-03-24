using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Facturacion.Pages.dAvances
{
    public class DeleteModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public DeleteModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AvanceConstruccion AvanceConstruccion { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AvanceConstruccion = await _context.AvancesConstruccion
                .Include(a => a.Propiedad).FirstOrDefaultAsync(m => m.ID == id);

            if (AvanceConstruccion == null)
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

            AvanceConstruccion = await _context.AvancesConstruccion.FindAsync(id);

            if (AvanceConstruccion != null)
            {
                _context.AvancesConstruccion.Remove(AvanceConstruccion);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
