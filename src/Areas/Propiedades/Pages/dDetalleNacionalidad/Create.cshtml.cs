using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dDetalleNacionalidad
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
        ViewData["ClienteID"] = new SelectList(_context.Clientes, "ID", "Cedula");
        ViewData["NacionalidadID"] = new SelectList(_context.Nacionalidades, "ID", "Descripcion");
            return Page();
        }

        [BindProperty]
        public DetalleNacionalidad DetalleNacionalidad { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DocumentosNacionales.Add(DetalleNacionalidad);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
