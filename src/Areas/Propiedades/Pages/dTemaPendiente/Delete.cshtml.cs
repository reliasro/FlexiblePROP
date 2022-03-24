using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dTemaPendiente
{
    public class DeleteModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public DeleteModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TemaPendiente TemaPendiente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TemaPendiente = await _context.TemasPendientes
                .Include(t => t.Propiedad)
                .Include(t => t.TipoContrato).FirstOrDefaultAsync(m => m.ID == id);

            if (TemaPendiente == null)
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

            TemaPendiente = await _context.TemasPendientes.FindAsync(id);

            if (TemaPendiente != null)
            {
                _context.TemasPendientes.Remove(TemaPendiente);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
