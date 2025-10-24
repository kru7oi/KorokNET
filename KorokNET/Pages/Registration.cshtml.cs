using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KorokNET.Models;

namespace KorokNET.Pages
{
    public class RegistrationModel : PageModel
    {
        private readonly KorokNET.Models.KorokNetdbContext _context;

        public RegistrationModel(KorokNET.Models.KorokNetdbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;


        public async Task<IActionResult> OnPostAsync()
        {
            User.RoleId = 1;

            _context.Users.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
