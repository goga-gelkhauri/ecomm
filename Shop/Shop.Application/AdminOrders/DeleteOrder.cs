using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.AdminOrders
{
    public class DeleteOrder
    {
        private ApplicationDbContext _context;

        public DeleteOrder(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Do(string reference)
        {
            var order = _context.Orders.FirstOrDefault(x => x.OrderRef == reference);
            _context.Remove(order);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
