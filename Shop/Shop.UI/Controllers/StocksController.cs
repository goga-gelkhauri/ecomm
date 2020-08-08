using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.AdminStock;
using Shop.Database;

namespace Shop.UI.Controllers
{
    [Route("[controller]")]
    [Authorize(Policy = "Manager")]
    public class StocksController : Controller
    {
        private ApplicationDbContext _context;
        public StocksController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet("")]
        public IActionResult GetStock() => Ok(new GetStock(_context).Do());

        [HttpPost("")]
        public async Task<IActionResult> CreateStock([FromBody] CreateStock.Request vm) => Ok((await new CreateStock(_context).Do(vm)));


        [HttpPut("")]
        public async Task<IActionResult> UpdateStock([FromBody] UpdateStock.Request vm) => Ok((await new UpdateStock(_context).Do(vm)));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStock(int id) => Ok((await new DeleteStock(_context).Do(id)));
    }
}