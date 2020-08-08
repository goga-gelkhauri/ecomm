using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Cart;
using Shop.Database;

namespace Shop.UI.Pages.Checkout
{
    public class CustomerInformationModel : PageModel
    {
        [Obsolete]
        private IHostingEnvironment _env;

        [Obsolete]
        public CustomerInformationModel(IHostingEnvironment env)
        {
            _env = env;
        }
        
        [BindProperty]
        public AddCustomerInformation.Request CustomerInformation { get; set; }

        [Obsolete]
        public IActionResult OnGet()
        {

            var Information = new GetCustomerInformation(HttpContext.Session).Do();
            if(Information == null)
            {
                if (_env.IsDevelopment())
                {
                    CustomerInformation = new AddCustomerInformation.Request
                    {
                        FirstName = "Asd",
                        LastName = "sad",
                        Email = "g@gmail.com",
                        PhoneNumber = "232",
                        Address1 = "23adas",
                        Address2 = "sad432",
                        City = "London",
                        PostCode = "2321"
                    };
                }
                return Page();
            }

            else
            {
                return RedirectToPage("/Checkout/Payment");
            }

        }


        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            new AddCustomerInformation(HttpContext.Session).Do(CustomerInformation);
            return RedirectToPage("/Checkout/Payment");

        }
    }
}