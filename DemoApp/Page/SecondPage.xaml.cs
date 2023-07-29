using DemoApp.ViewModel;

namespace DemoApp.Page;

public partial class SecondPage : ContentPage
{
	public SecondPage(SecondPageVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

        if (labela1.Text == "")
        {
            LabelOneVal.Text = "";
            return;
        }

        LabelOneVal.Text = (string)"You entered: " + labela1.Text;
    }
}