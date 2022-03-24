using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dAreaPropiedad
{
    public class CreateModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public CreateModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet =true)]
        public int PropiedadID { get; set; }

        public IActionResult OnGet()
        {
            ViewData["PropiedadID"] = new SelectList(_context.Propiedades, "ID", "FichaPropiedad");
            ViewData["UnidadID"] = new SelectList(_context.Unidades, "ID", "Descripcion");

             AreaPropiedad = new AreaPropiedad();
            AreaPropiedad.PropiedadID = PropiedadID;
                return Page();
        }

        [BindProperty]
        public AreaPropiedad AreaPropiedad { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AreasPropiedades.Add(AreaPropiedad);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
