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
    public class ReviewModel : PageModel
    {
        private readonly KorokNET.Models.KorokNetdbContext _context;

        public ReviewModel(KorokNET.Models.KorokNetdbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int? id)
        {
            
            return Page();
        }

        [BindProperty]
        public Review Review { get; set; } = default!;
        public Order? Order { get; set; } = default!;
        public User? User { get; set; } = default!;
        
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            Order = _context.Orders.FirstOrDefault(order => order.Id == id);
            User = _context.Users.FirstOrDefault(user => user.Id == Order.UserId);

            Review.CourseId = Order.CourseId;
            Review.UserId = Order.UserId;

            _context.Reviews.Add(Review);
            await _context.SaveChangesAsync();

            return RedirectToPage("./User", User);
        }
    }
}
