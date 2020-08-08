using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.AdminOrders;
using Shop.Database;

namespace Shop.UI.Controllers
{
    [Route("[controller]")]
    [Authorize(Policy = "Admin")]
    public class OrdersController : Controller
    {

        [HttpGet("")]
        public IActionResult GetOrders([FromServices] GetOrders getOrders) => Ok(getOrders.Do());


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStock(string id, [FromServices] DeleteOrder deleteOrder) => Ok((deleteOrder.Do(id)));
    }
}