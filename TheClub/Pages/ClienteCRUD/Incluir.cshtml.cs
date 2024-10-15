using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TheClub.Data;
using TheClub.Models;

namespace TheClub.Pages.ClienteCRUD
{
    public class IncluirModel : PageModel
    {
        private readonly ApplicationDBContext _context;

        [BindProperty]
        public Cliente Cliente { get; set; }

        public IncluirModel(ApplicationDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var Cliente = new Cliente();
            if (await TryUpdateModelAsync<Cliente>(Cliente, "cliente", obj => obj.Nome, obj => obj.DataDeNascimento, o => o.Email, o => o.CPF))
            {
                _context.Cliente.Add(Cliente);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Listar");
            }

            

            return Page();
        }
    }
}
