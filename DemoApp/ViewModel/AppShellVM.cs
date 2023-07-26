using DemoApp.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.ViewModel;

public class AppShellVM
{
    public AppShellVM()
    {
        RegisterRoutes();
    }

    private void RegisterRoutes()
    {
        Routing.RegisterRoute(nameof(FirstPage), typeof(FirstPage));
    }
}
