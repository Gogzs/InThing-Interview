using DemoApp.ViewModel;

namespace DemoApp.Page;

public partial class FirstPage : ContentPage
{
	public FirstPage(FirstPageVM vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}