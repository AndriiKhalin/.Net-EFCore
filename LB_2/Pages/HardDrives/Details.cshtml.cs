using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LB_2.Models.Context;
using LB_2.Models.Data;

namespace LB_2.Pages.HardDrives
{
    public class DetailsModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public DetailsModel(ComputerDbContext context)
        {
            _context = context;
        }

        public HardDrive HardDrive { get; set; } = new HardDrive();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hardDrive = await _context.HardDrives.FirstOrDefaultAsync(m => m.Id == id);
            if (hardDrive == null)
            {
                return NotFound();
            }
            else
            {
                HardDrive = hardDrive;
            }
            return Page();
        }
    }
}
