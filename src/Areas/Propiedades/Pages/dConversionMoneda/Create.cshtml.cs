using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dConversionMoneda
{
    public class CreateModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public CreateModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MonedaDestinoID"] = new SelectList(_context.Monedas, "ID", "Descripcion");
        ViewData["MonedaOrigenID"] = new SelectList(_context.Monedas, "ID", "Descripcion");
            return Page();
        }

        [BindProperty]
        public ConversionMoneda ConversionMoneda { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ConversionesMonedas.Add(ConversionMoneda);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
