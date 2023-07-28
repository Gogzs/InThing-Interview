using DemoApp.ViewModel;

namespace DemoApp.Page;

public partial class SecondPage : ContentPage
{
	public SecondPage(SecondPageVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }

    async void Button_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Button cliked", "Display msg", "ok");
    }
}