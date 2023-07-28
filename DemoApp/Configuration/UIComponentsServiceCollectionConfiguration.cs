using Android.Widget;
using DemoApp.Page;
using DemoApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Configuration
{
    public static class UIComponentsServiceCollectionConfiguration
    {
        public static IServiceCollection AddUIComponents(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<AppShellVM>()
                .AddTransient<AppShell>()

                .AddSingleton<MainVM>()
                .AddSingleton<MainPage>()

                .AddSingleton<FirstPageVM>()
                .AddSingleton<FirstPage>()
                .AddSingleton<SecondPageVM>()
                .AddSingleton<SecondPage>();

            return serviceCollection;
        }
    }
}
