using KorokNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KorokNET.Pages
{
    public class IndexModel : PageModel
    {
        private readonly KorokNetdbContext _context;

        [BindProperty]
        public User User { get; set; } = default!;
        public IndexModel(KorokNetdbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // login: petr
            // pass: 123
            User? currentUser = _context.Users.FirstOrDefault(user => user.Login == User.Login && user.Password == User.Password);

            if (currentUser != null)
            {
                return RedirectToPage("./User", currentUser);
            }

            ModelState.AddModelError(string.Empty, "Пользователь не найден");

            return Page();
        }
    }
}
