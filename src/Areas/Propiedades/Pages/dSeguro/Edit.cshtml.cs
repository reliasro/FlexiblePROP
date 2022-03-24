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

namespace ContosoUniversity.Areas.Propiedades.Pages.dSeguro
{
    public class EditModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public EditModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Seguro Seguro { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seguro = await _context.Seguros
                .Include(s => s.MonedaValorAsegurado)
                .Include(s => s.Propiedad)
                .Include(s => s.TipoSeguro).FirstOrDefaultAsync(m => m.ID == id);

            if (Seguro == null)
            {
                return NotFound();
            }
           ViewData["MonedaID"] = new SelectList(_context.Monedas, "ID", "Descripcion");
           ViewData["PropiedadID"] = new SelectList(_context.Propiedades, "ID", "FichaPropiedad");
           ViewData["TipoSeguroID"] = new SelectList(_context.TiposSeguro, "ID", "Descripcion");
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

            _context.Attach(Seguro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeguroExists(Seguro.ID))
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

        private bool SeguroExists(int id)
        {
            return _context.Seguros.Any(e => e.ID == id);
        }
    }
}
