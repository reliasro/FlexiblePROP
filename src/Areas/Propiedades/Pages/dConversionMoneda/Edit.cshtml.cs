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

namespace ContosoUniversity.Areas.Propiedades.Pages.dConversionMoneda
{
    public class EditModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public EditModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ConversionMoneda ConversionMoneda { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ConversionMoneda = await _context.ConversionesMonedas
                .Include(c => c.MonedaDestino)
                .Include(c => c.MonedaOrigen).FirstOrDefaultAsync(m => m.ID == id);

            if (ConversionMoneda == null)
            {
                return NotFound();
            }
           ViewData["MonedaDestinoID"] = new SelectList(_context.Monedas, "ID", "Descripcion");
           ViewData["MonedaOrigenID"] = new SelectList(_context.Monedas, "ID", "Descripcion");
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

            _context.Attach(ConversionMoneda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConversionMonedaExists(ConversionMoneda.ID))
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

        private bool ConversionMonedaExists(int id)
        {
            return _context.ConversionesMonedas.Any(e => e.ID == id);
        }
    }
}
