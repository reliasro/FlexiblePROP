using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dTipoSeguro
{
    public class DeleteModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public DeleteModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TipoSeguro TipoSeguro { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TipoSeguro = await _context.TiposSeguro.FirstOrDefaultAsync(m => m.ID == id);

            if (TipoSeguro == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TipoSeguro = await _context.TiposSeguro.FindAsync(id);

            if (TipoSeguro != null)
            {
                _context.TiposSeguro.Remove(TipoSeguro);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
