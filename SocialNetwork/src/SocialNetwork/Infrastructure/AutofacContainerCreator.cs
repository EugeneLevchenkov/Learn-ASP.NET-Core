using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SocialNetwork.Infrastructure
{
    public static class AutofacServiceExtensions
    {
        public static void AddAutofac(this IServiceCollection services, Action<IContainer> containerSetter)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<DataModule>();
            builder.Populate(services);
            var container = builder.Build();
            containerSetter(container);
        }
    }
}
