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

namespace ContosoUniversity.Areas.Propiedades.Pages.dDetalleNacionalidad
{
    public class EditModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public EditModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DetalleNacionalidad DetalleNacionalidad { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DetalleNacionalidad = await _context.DocumentosNacionales
                .Include(d => d.Cliente)
                .Include(d => d.Nacionalidad).FirstOrDefaultAsync(m => m.ClienteID == id);

            if (DetalleNacionalidad == null)
            {
                return NotFound();
            }
           ViewData["ClienteID"] = new SelectList(_context.Clientes, "ID", "Cedula");
           ViewData["NacionalidadID"] = new SelectList(_context.Nacionalidades, "ID", "Descripcion");
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

            _context.Attach(DetalleNacionalidad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleNacionalidadExists(DetalleNacionalidad.ClienteID))
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

        private bool DetalleNacionalidadExists(int id)
        {
            return _context.DocumentosNacionales.Any(e => e.ClienteID == id);
        }
    }
}
