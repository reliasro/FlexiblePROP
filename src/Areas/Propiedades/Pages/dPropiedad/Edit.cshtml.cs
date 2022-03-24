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

namespace ContosoUniversity.Areas.Propiedades.Pages.dPropiedad
{
    public class EditModel : PageModel
    {
        private readonly ContosoUniversity.Data.FlexiblePROPContext _context;

        public EditModel(ContosoUniversity.Data.FlexiblePROPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Propiedad Propiedad { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Propiedad = await _context.Propiedades
                .AsSplitQuery( ) //Aqui evitamos lentitud mandando a que se ejecuten querys separados por cada lista asociada
                .Include(p => p.AreasPropiedad)
                .Include(p => p.EstadoPropiedad)
                .Include(p => p.MonedaValores)
                .Include(p => p.TipoPropiedad)
                .Include(p => p.UnidadEspacio)
                .Include(p => p.Propietario)
                .Include(p => p.TemasPendiente)
                .Include(p => p.Equipos)
                .Include(p => p.Contratos).ThenInclude(p =>p.TipoContrato)
                .Include(p => p.Seguros).ThenInclude(p => p.TipoSeguro)
                .Include(p => p.AvancesConstruccion)
                .Include(p => p.Vendedor).FirstOrDefaultAsync(m => m.ID == id);

            if (Propiedad == null)
            {
                return NotFound();
            }
           ViewData["EstadoPropiedadID"] = new SelectList(_context.Set<EstadoPropiedad>(), "ID", "Descripcion");
           ViewData["MonedaID"] = new SelectList(_context.Monedas, "ID", "Descripcion");
           ViewData["TipoPropiedadID"] = new SelectList(_context.TiposPropiedades, "ID", "Descripcion");
           ViewData["UnidadID"] = new SelectList(_context.Unidades, "ID", "Descripcion");
           ViewData["VendedorID"] = new SelectList(_context.Vendedores, "ID", "FichaVendedor");
           ViewData["PropietarioID"] = new SelectList(_context.Clientes, "ID", "FichaPropietario");
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

            _context.Attach(Propiedad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropiedadExists(Propiedad.ID))
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

        private bool PropiedadExists(int id)
        {
            return _context.Propiedades.Any(e => e.ID == id);
        }
    }
}
