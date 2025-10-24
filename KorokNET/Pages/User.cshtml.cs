using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KorokNET.Models;

namespace KorokNET.Pages
{
    public class UserModel : PageModel
    {
        private readonly KorokNET.Models.KorokNetdbContext _context;

        public UserModel(KorokNET.Models.KorokNetdbContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        public async Task OnGetAsync(User currentUser)
        {
            Order = await _context.Orders.Where(order => order.UserId == currentUser.Id).ToListAsync();
        }
    }
}
