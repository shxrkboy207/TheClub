﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly TheClub.Data.ApplicationDBContext _context;

        public IndexModel(TheClub.Data.ApplicationDBContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; }

        public async Task OnGetAsync()
        {
            Produto = await _context.Produto.ToListAsync();
        }
    }
}
