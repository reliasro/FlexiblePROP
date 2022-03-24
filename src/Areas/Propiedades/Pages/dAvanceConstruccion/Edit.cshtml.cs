using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dAvanceConstruccion
{
    public class EditModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public EditModel(ContosoUniversity.Data.FlexiblePROPContext context)
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
           ViewData["PropiedadID"] = new SelectList(_context.Propiedades, "ID", "FichaPropiedad");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AvanceConstruccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvanceConstruccionExists(AvanceConstruccion.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AvanceConstruccionExists(int id)
        {
            return _context.AvancesConstruccion.Any(e => e.ID == id);
        }
    }
}
