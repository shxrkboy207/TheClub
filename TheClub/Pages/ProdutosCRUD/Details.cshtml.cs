using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheClub.Data;
using TheClub.Models;

namespace TheClub.ProdutosCrud
{
    public class DetailsModel : PageModel
    {
        private readonly TheClub.Data.ApplicationDBContext _context;

        public DetailsModel(TheClub.Data.ApplicationDBContext context)
        {
            _context = context;
        }

        public Produto Produto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produto = await _context.Produto.FirstOrDefaultAsync(m => m.iDProduto == id);

            if (Produto == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
