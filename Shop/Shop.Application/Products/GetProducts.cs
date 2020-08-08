﻿using System;
using System.Collections.Generic;
using System.Text;
using Shop.Database;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Shop.Application.GetProducts
{
    public class GetProducts
    {
        private ApplicationDbContext _context;

        public GetProducts(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductViewModel> Do() =>
            _context.Products.Include(x => x.Stock).ToList().Select(x => new ProductViewModel{
                Name = x.Name,
                Description = x.Description,
                Value = $"${x.Value.ToString("N2")}",
                StockCount = x.Stock.Sum(y => y.Qty)
            });
        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Value { get; set; }
            public int StockCount { get; set; }
        }

    }

}
