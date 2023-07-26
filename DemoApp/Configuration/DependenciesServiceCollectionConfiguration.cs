using Android.SE.Omapi;
using DemoApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Configuration
{
    public static class DependenciesServiceCollectionConfiguration
    {
        public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<NavigationService>();

            return serviceCollection;
        }
    }
}
