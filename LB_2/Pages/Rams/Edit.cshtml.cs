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

namespace LB_2.Pages.Rams
{
    public class EditModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public EditModel(ComputerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ram Ram { get; set; } = new Ram();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                Response.Redirect("/Rams/Index");
                return NotFound();
            }

            var ram = await _context.Rams.FirstOrDefaultAsync(m => m.Id == id);
            if (ram == null)
            {
                Response.Redirect("/Rams/Index");
                return NotFound();
            }
            Ram = ram;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {

            if (id == null)
            {
                Response.Redirect("/Rams/Index");
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var ram = await _context.Rams.FirstOrDefaultAsync(m => m.Id == id);

            _context.Entry(ram).CurrentValues.SetValues(Ram);


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
