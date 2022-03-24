using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
        using ContosoUniversity.Data;
        using ContosoUniversity.Models;

namespace ContosoUniversity.Pages.Configuraciones
{
    public class IndexModel : PageModel
    {
    private readonly ContosoUniversity.Data.FlexiblePROPContext _context;
    public int IDItemSeleccionado { get; set; }

    [BindProperty(SupportsGet = true)]
    public string moduloConfig  { get; set; }

        public IndexModel(ContosoUniversity.Data.FlexiblePROPContext context)
    {
         _context = context;
    }

    public IList<Configuracion>  Configuracion { get;set; }

    public async Task OnGetAsync(int? id )
    {
        //Saco la interface Queriable del objeto DBSET
        IQueryable<Configuracion> filtroConfs = from c  in _context.Configuraciones 
                                                select c;
        if (id != null)
         {
            IDItemSeleccionado = id.Value;
         }

            //Deseo filtrar los parametros por modulo si veo el valor
            if (!string.IsNullOrEmpty(moduloConfig))
            {
                filtroConfs = filtroConfs.Where(s => s.Modulo.Contains(moduloConfig));
                Configuracion = await filtroConfs.ToListAsync(); //Convierto a lista y consulto la BD
            }
            else { Configuracion = await _context.Configuraciones.ToListAsync(); }


        }
    }
    }
