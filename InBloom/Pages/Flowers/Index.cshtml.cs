using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InBloom.Models;

namespace InBloom.Pages_Flowers
{
    public class IndexModel : PageModel
    {
        private readonly FlowerContext _context;

        public IndexModel(FlowerContext context)
        {
            _context = context;
        }

        public IList<Flower> Flower { get;set; }

        public async Task OnGetAsync()
        {
            Flower = await _context.Flower.ToListAsync();
        }
    }
}
