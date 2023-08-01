using DemoApp.ViewModel;

namespace DemoApp.Page;

public partial class SecondPage : ContentPage
{
	public SecondPage(SecondPageVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }

   
}