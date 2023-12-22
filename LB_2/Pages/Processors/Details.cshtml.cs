using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LB_2.Models.Context;
using LB_2.Models.Data;

namespace LB_2.Pages.Processors
{
    public class DetailsModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public DetailsModel(ComputerDbContext context)
        {
            _context = context;
        }

        public Processor Processor { get; set; } = new Processor();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processor = await _context.Processors.FirstOrDefaultAsync(m => m.Id == id);
            if (processor == null)
            {
                return NotFound();
            }
            else
            {
                Processor = processor;
            }
            return Page();
        }
    }
}
