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

namespace LB_2.Pages.ComponentComputers
{
    public class EditModel : PageModel
    {
        private readonly ComputerDbContext _context;

        public EditModel(ComputerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ComponentComputer ComponentComputer { get; set; } = new ComponentComputer();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                Response.Redirect("/ComponentComputers/Index");
                return NotFound();
            }

            var componentComputer = await _context.ComponentComputers.FirstOrDefaultAsync(m => m.Id == id);
            if (componentComputer == null)
            {
                Response.Redirect("/ComponentComputers/Index");
                return NotFound();
            }
            ComponentComputer = componentComputer;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {

            if (id == null)
            {
                Response.Redirect("/ComponentComputers/Index");
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var componentComputer = await _context.ComponentComputers.FirstOrDefaultAsync(m => m.Id == id);

            _context.Entry(componentComputer).CurrentValues.SetValues(ComponentComputer);


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
