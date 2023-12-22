using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LB_2.Models.Context;
using LB_2.Models.Data;

namespace LB_2.Pages.Computers
{
    public class DetailsModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public DetailsModel(ComputerDbContext context)
        {
            _context = context;
        }

        public Computer Computer { get; set; } = new Computer();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computer = await _context.Computers.FirstOrDefaultAsync(m => m.Id == id);
            if (computer == null)
            {
                return NotFound();
            }
            else
            {
                Computer = computer;
            }
            return Page();
        }
    }
}
