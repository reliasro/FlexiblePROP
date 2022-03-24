using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
        using ContosoUniversity.Data;
        using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.Propiedades.Pages.dPropiedad
{
    public class IndexModel : PageModel
    {
    private readonly ContosoUniversity.Data.FlexiblePROPContext _context;
    public int IDItemSeleccionado { get; set; }

    public IndexModel(ContosoUniversity.Data.FlexiblePROPContext context)
    {
        _context = context;
    }

    public IList<Propiedad>
    Propiedad { get;set; }

    public async Task OnGetAsync(int? id)
    {
        Propiedad = await _context.Propiedades
                .Include(p => p.EstadoPropiedad)
                .Include(p => p.MonedaValores)
                .Include(p => p.TipoPropiedad)
                .Include(p => p.UnidadEspacio)
                .Include(p => p.Propietario)
                .Include(p => p.Vendedor).ToListAsync();
        if (id != null)
         {
            IDItemSeleccionado = id.Value;
         }
    }
    }
    }
