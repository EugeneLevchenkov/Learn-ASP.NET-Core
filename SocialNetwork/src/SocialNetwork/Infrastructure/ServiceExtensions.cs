using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.Business.Infrastructure;
using SocialNetwork.Data.Infrastructure;
using System;

namespace SocialNetwork.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void AddAutofac(this IServiceCollection services, Action<IContainer> containerSetter)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<DataModule>();
            builder.RegisterModule<BusinessModule>();
            builder.RegisterModule<WebModule>();
            builder.Populate(services);
            var container = builder.Build();
            containerSetter(container);
        }
    }
}
