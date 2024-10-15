using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheClub.Data;
using TheClub.Models;

namespace TheClub.Pages.ClienteCRUD
{
    public class ListarModel : PageModel
    {
        private readonly ApplicationDBContext _context;

        public IList<Cliente> Clientes { get; set; }

        public ListarModel(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Clientes = await _context.Cliente.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.Cliente.Remove(cliente);
            await _context.SaveChangesAsync();

            return Page();
        }
    }
}
