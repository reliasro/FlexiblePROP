using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dTemaPendiente
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
        ViewData["PropiedadID"] = new SelectList(_context.Propiedades, "ID", "FichaPropiedad");
        ViewData["TipoContratoID"] = new SelectList(_context.TiposContrato, "ID", "Descripcion");
            return Page();
        }

        [BindProperty]
        public TemaPendiente TemaPendiente { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TemasPendientes.Add(TemaPendiente);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
