using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dGrupoCompania
{
    public class DeleteModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public DeleteModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GrupoCompania GrupoCompania { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GrupoCompania = await _context.GruposCompania.FirstOrDefaultAsync(m => m.ID == id);

            if (GrupoCompania == null)
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

            GrupoCompania = await _context.GruposCompania.FindAsync(id);

            if (GrupoCompania != null)
            {
                _context.GruposCompania.Remove(GrupoCompania);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
