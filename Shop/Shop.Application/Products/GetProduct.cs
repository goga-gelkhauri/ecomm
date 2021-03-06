﻿using Microsoft.EntityFrameworkCore;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Products
{
    public class GetProduct
    {
        private ApplicationDbContext _context;

        public GetProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ProductViewModel> Do(string name)
        {

            var stockOnHold = _context.StockOnHolds.Where(x => x.ExpiryDate < DateTime.Now).ToList();

            if(stockOnHold.Count > 0)
            {
                var stockToReturn = _context.Stock.ToList().Where(x => stockOnHold.Any(y => y.StockId == x.Id));

                foreach (var stock in stockToReturn)
                {
                    stock.Qty = stock.Qty + stockOnHold.FirstOrDefault(x => x.StockId == stock.Id).Qty;
                }

                _context.StockOnHolds.RemoveRange(stockOnHold);
                await _context.SaveChangesAsync();
            }

           return  _context.Products.Include(x => x.Stock).Where(x => x.Name == name).Select(x => new ProductViewModel
            {
                Name = x.Name,
                Description = x.Description,
                Value = x.Value,
                Stock = x.Stock.Select(y => new StockViewModel
                {
                    Id = y.Id,
                    Description = y.Description,
                    InStock = y.Qty > 0,
                    Qty = y.Qty

                }),

            }).FirstOrDefault();
        }
        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
            public IEnumerable<StockViewModel> Stock { get; set; }
        }

        public class StockViewModel
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public bool InStock { get; set; }
            public int Qty { get; set; }
        }

    }
}
