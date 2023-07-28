using DemoApp.Page;

namespace DemoApp.Service;

public class NavigationService
{
    public async Task NavigateToFirstPageAsync()
    {
        var state = Shell.Current.CurrentState;
        await Shell.Current.GoToAsync($"{state.Location}/{nameof(FirstPage)}");
    }
    public async Task NavigateToSecondPageAsync()
    {
        var state = Shell.Current.CurrentState;
        await Shell.Current.GoToAsync($"{state.Location}/{nameof(SecondPage)}");
    }
}
