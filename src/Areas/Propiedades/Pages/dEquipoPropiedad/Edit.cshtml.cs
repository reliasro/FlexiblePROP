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

namespace ContosoUniversity.Areas.Propiedades.Pages.dEquipoPropiedad
{
    public class EditModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        [BindProperty(SupportsGet = true)]
        public string RutaRetorno { get; set; }

        public EditModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EquipoPropiedad EquipoPropiedad { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EquipoPropiedad = await _context.EquiposPropiedad
                .Include(e => e.Propiedad).FirstOrDefaultAsync(m => m.ID == id);

            if (EquipoPropiedad == null)
            {
                return NotFound();
            }
           ViewData["PropiedadID"] = new SelectList(_context.Propiedades, "ID", "FichaPropiedad");
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

            _context.Attach(EquipoPropiedad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipoPropiedadExists(EquipoPropiedad.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            if ( RutaRetorno.Length==0) return RedirectToPage("./Index");
            else return Redirect(RutaRetorno);
        }

        private bool EquipoPropiedadExists(int id)
        {
            return _context.EquiposPropiedad.Any(e => e.ID == id);
        }
    }
}
