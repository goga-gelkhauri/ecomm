using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Shop.Application.GetProducts;
using Shop.Database;

namespace Shop.UI.Pages
{
    
    public class IndexModel : PageModel
    {
        public IEnumerable<GetProducts.ProductViewModel> Products {get;set;}
        
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration Configuration;
        public string Title;

        private ApplicationDbContext _context;
        
        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration,ApplicationDbContext context)
        {
            _logger = logger;
            Configuration = configuration;
            _context = context;
        }

        public void OnGet()
        {
            Products = new GetProducts(_context).Do();
     
        }


    }
}
