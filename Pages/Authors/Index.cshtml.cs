using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sava_Razvan_Cristian_Lab2.Data;
using Sava_Razvan_Cristian_Lab2.Models;

namespace Sava_Razvan_Cristian_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Sava_Razvan_Cristian_Lab2.Data.Sava_Razvan_Cristian_Lab2Context _context;

        public IndexModel(Sava_Razvan_Cristian_Lab2.Data.Sava_Razvan_Cristian_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
