using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Pages.Configuraciones
{
    public class CreateModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;
        public enum ModulosConfiguracion { Servicio=1, Ventas=2, Facturacion=3, CuentasxCobrar=4 }

        public CreateModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["Origen"] = HttpContext.Request.Headers["Referer"];
            return Page();
        }

        [BindProperty]
        public Configuracion Configuracion { get; set; }

        //Esta propiedad es para que sea alimentada via URL
        [BindProperty(SupportsGet = true)]
        public string UrlOrigen { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Configuraciones.Add(Configuracion);
            await _context.SaveChangesAsync();

            // return RedirectToPage("./Index");
            return Redirect(UrlOrigen);

        }
    }
}
