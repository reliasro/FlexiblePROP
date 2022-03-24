using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
        using ContosoUniversity.Data;
        using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dMoneda
{
    public class IndexModel : PageModel
    {
    private readonly ContosoUniversity.Data.FlexiblePROPContext _context;
    public int IDItemSeleccionado { get; set; }

    public IndexModel(ContosoUniversity.Data.FlexiblePROPContext context)
    {
    _context = context;
    }

    public IList<Moneda>
    Moneda { get;set; }

    public async Task OnGetAsync(int? id)
    {
        Moneda = await _context.Monedas.ToListAsync();
        if (id != null)
         {
            IDItemSeleccionado = id.Value;
         }
    }
    }
    }
