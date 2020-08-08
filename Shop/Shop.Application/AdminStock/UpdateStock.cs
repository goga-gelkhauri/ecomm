﻿using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.AdminStock
{
    public class UpdateStock
    {
        private ApplicationDbContext _context;

        public UpdateStock(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response> Do(Request request)
        {
            var stocks = new List<Stock>();
            foreach (var stock in request.Stock)
            {
                stocks.Add(new Stock { 
                    Id = stock.Id,
                    Description = stock.Description,
                    Qty = stock.Qty,
                    ProductId = stock.ProductId
                });
            }
            

            _context.Stock.UpdateRange(stocks);
            await _context.SaveChangesAsync();

            return new Response
            {
                Stock = request.Stock
            };

        }

        public class StockViewmodel
        {
            public int Id  { get; set; }
            public int ProductId { get; set; }
            public string Description { get; set; }
            public int Qty { get; set; }
        }

        public class Request
        {
            public IEnumerable<StockViewmodel> Stock { get; set; }
        }

        public class Response
        {
            public IEnumerable<StockViewmodel> Stock { get; set; }
        }
    }
}
