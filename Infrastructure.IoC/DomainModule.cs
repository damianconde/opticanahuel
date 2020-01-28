using Application;
using Domain.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infrastructure.IoC
{
    public static class DomainModule
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddSingleton<IBillingService, BillingService>();

            return services;
        }
    }
}
