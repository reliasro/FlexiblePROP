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

namespace ContosoUniversity.Areas.Propiedades.Pages.dInmobiliaria
{
    public class EditModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public EditModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Inmobiliaria Inmobiliaria { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Inmobiliaria = await _context.Inmobiliarias.FirstOrDefaultAsync(m => m.ID == id);

            if (Inmobiliaria == null)
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

            _context.Attach(Inmobiliaria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InmobiliariaExists(Inmobiliaria.ID))
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

        private bool InmobiliariaExists(int id)
        {
            return _context.Inmobiliarias.Any(e => e.ID == id);
        }
    }
}
