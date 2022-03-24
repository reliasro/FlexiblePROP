using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dConversionMoneda
{
    public class DetailsModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public DetailsModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        public ConversionMoneda ConversionMoneda { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ConversionMoneda = await _context.ConversionesMonedas
                .Include(c => c.MonedaDestino)
                .Include(c => c.MonedaOrigen).FirstOrDefaultAsync(m => m.ID == id);

            if (ConversionMoneda == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
