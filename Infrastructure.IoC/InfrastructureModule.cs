using AfipLoginService;
using AfipServiceClient;
using Domain.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.IoC
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IAfipService, AfipService>();
            services.AddSingleton<ServiceSoap>(o => new ServiceSoapClient(ServiceSoapClient.EndpointConfiguration.ServiceSoap12));
            services.AddSingleton<LoginCMS>(o => new LoginCMSClient(LoginCMSClient.EndpointConfiguration.LoginCms));

            return services;
        }
    }
}
