using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dSeguro
{
    public class DetailsModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public DetailsModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        public Seguro Seguro { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seguro = await _context.Seguros
                .Include(s => s.MonedaValorAsegurado)
                .Include(s => s.Propiedad)
                .Include(s => s.TipoSeguro).FirstOrDefaultAsync(m => m.ID == id);

            if (Seguro == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
