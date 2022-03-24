using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dPropiedad
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
            ViewData["EstadoPropiedadID"] = new SelectList(_context.Set<EstadoPropiedad>(), "ID", "Descripcion");
            ViewData["MonedaID"] = new SelectList(_context.Monedas, "ID", "Descripcion");
            ViewData["TipoPropiedadID"] = new SelectList(_context.TiposPropiedades, "ID", "Descripcion");
            ViewData["UnidadID"] = new SelectList(_context.Unidades, "ID", "Descripcion");
            ViewData["VendedorID"] = new SelectList(_context.Vendedores, "ID", "FichaVendedor");
            ViewData["PropietarioID"] = new SelectList(_context.Clientes, "ID", "FichaPropietario");
            return Page();
        }

        [BindProperty]
        public Propiedad Propiedad { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Propiedades.Add(Propiedad);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
