using Microsoft.Extensions.DependencyInjection;
using Shop.Application.AdminOrders;
using Shop.Application.AdminUser;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Application
{
    public static class ServiceRegister
    {
        public static IServiceCollection ApplicationServices(this IServiceCollection @this)
        {

            @this.AddTransient<GetOrder>();
            @this.AddTransient<GetOrders>();
            @this.AddTransient<DeleteOrder>();
            @this.AddTransient<CreateUser>();

            return @this;
        }
    }
}
