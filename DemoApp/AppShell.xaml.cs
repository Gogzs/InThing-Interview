using DemoApp.ViewModel;

namespace DemoApp;

public partial class AppShell : Shell
{
	public AppShell(AppShellVM vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}
