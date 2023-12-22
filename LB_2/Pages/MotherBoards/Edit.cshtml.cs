using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LB_2.Models.Context;
using LB_2.Models.Data;

namespace LB_2.Pages.MotherBoards
{
    public class EditModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public EditModel(ComputerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MotherBoard MotherBoard { get; set; } = new MotherBoard();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                Response.Redirect("/MotherBoards/Index");
                return NotFound();
            }

            var motherBoard = await _context.MotherBoards.FirstOrDefaultAsync(m => m.Id == id);
            if (motherBoard == null)
            {
                Response.Redirect("/MotherBoards/Index");
                return NotFound();
            }
            MotherBoard = motherBoard;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {

            if (id == null)
            {
                Response.Redirect("/MotherBoards/Index");
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var motherBoard = await _context.MotherBoards.FirstOrDefaultAsync(m => m.Id == id);

            _context.Entry(motherBoard).CurrentValues.SetValues(MotherBoard);


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return RedirectToPage("./Index");
        }

    }
}
