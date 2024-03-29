﻿using DevIO.Bussines.Interface;
using DevIO.Bussines.Notificacoes;
using DevIO.Bussines.Services;
using DevIO.Data.Context;
using DevIO.Data.Repository;

namespace DevIO.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ClinicaDbContext>();
            services.AddScoped<IConsultaRepository, ConsultaRepository>();


            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IConsultaService, ConsultaService>();
      
            return services;
        }
    }
}