using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dRolCliente
{
    public class DeleteModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public DeleteModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RolCliente RolCliente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RolCliente = await _context.RolesClientes.FirstOrDefaultAsync(m => m.ID == id);

            if (RolCliente == null)
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

            RolCliente = await _context.RolesClientes.FindAsync(id);

            if (RolCliente != null)
            {
                _context.RolesClientes.Remove(RolCliente);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
