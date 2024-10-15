using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheClub.Data;
using TheClub.Models;

namespace TheClub.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private ApplicationDBContext _context;

        public IList<Produto> Produtos;


        public IndexModel(ILogger<IndexModel> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context; 
        }

        public async Task OnGetAsync()
        {
            Produtos = await _context.Produto.ToListAsync<Produto>();
        }
    }
}
