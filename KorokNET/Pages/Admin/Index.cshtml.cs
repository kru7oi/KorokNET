using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KorokNET.Models;

namespace KorokNET.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly KorokNET.Models.KorokNetdbContext _context;

        public IndexModel(KorokNET.Models.KorokNetdbContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;
        public IList<OrderStatus> OrderStatus { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public int OrderStatusId { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Order = await _context.Orders.ToListAsync();

            OrderStatus = await _context.OrderStatuses.ToListAsync();

            // 1. Проверка наличия значения
            if (OrderStatusId == 0)
            {
                Order = await _context.Orders.ToListAsync();
            }
            else
            {
                Order = await _context.Orders.Where(order => order.OrderStatusId == OrderStatusId).ToListAsync();
            }
        }
    }
}
