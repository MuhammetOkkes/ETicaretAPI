﻿using ETicaretAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Persistence.Repositories;
using ETicaretAPI.Application.Repositories.Orders;
using ETicaretAPI.Application.Repositories.Customers;
using ETicaretAPI.Application.Repositories.Products;
using ETicaretAPI.Persistence.Repositories.Products;
using ETicaretAPI.Persistence.Repositories.Products;
using ETicaretAPI.Persistence.Repositories.Orders;
using ETicaretAPI.Persistence.Repositories.Customers;



namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {          
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

        }
    }
}
