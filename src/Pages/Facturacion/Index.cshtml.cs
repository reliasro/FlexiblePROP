using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Pages.Facturacion
{
    public class IndexModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public IndexModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        public IList<Factura> Factura { get;set; }

        public async Task OnGetAsync()
        {
            Factura = await _context.Facturas.ToListAsync();
        }
    }
}
