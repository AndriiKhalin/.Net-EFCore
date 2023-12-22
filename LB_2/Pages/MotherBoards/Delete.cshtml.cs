using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LB_2.Models.Context;
using LB_2.Models.Data;

namespace LB_2.Pages.MotherBoards
{
    public class DeleteModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public DeleteModel(ComputerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MotherBoard MotherBoard { get; set; } = new MotherBoard();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motherBoard = await _context.MotherBoards.FirstOrDefaultAsync(m => m.Id == id);

            if (motherBoard == null)
            {
                return NotFound();
            }
            else
            {
                MotherBoard = motherBoard;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motherBoard = await _context.MotherBoards.FindAsync(id);
            if (motherBoard != null)
            {
                MotherBoard = motherBoard;
                _context.MotherBoards.Remove(MotherBoard);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
