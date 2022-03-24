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

namespace ContosoUniversity.Pages.Configuraciones
{
    public class EditModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        //Este valor es alimentado via la URL  
        [BindProperty(SupportsGet = true)]
        public string UrlOrigen { get; set; }

        public EditModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Configuracion Configuracion { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            ViewData["Origen"] = HttpContext.Request.Headers["Referer"];
            if (id == null)
            {
                return NotFound();
            }

            Configuracion = await _context.Configuraciones.FirstOrDefaultAsync(m => m.ID == id);

            if (Configuracion == null)
            {
                return NotFound();
            }
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

            _context.Attach(Configuracion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConfiguracionExists(Configuracion.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Redirect(UrlOrigen);
            
        }

        private bool ConfiguracionExists(int id)
        {
            return _context.Configuraciones.Any(e => e.ID == id);
        }
    }
}
