using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DemoApp.Service;

namespace DemoApp.ViewModel;

public class MainVM : ObservableRecipient
{
    private NavigationService _navService;
    private int _count;
    private string _message;

    public AsyncRelayCommand GoToFirstPageCommand { get; set; }
    public RelayCommand IncreaseCounterAndUpdateMessageCommand { get; set; }

    public string Message
    {
        get => _message; 
        set => SetProperty(ref _message, value); 
    }

    public MainVM(NavigationService navService)
    {
        GoToFirstPageCommand = new AsyncRelayCommand(GoToFirstPageAsync);
        IncreaseCounterAndUpdateMessageCommand = new RelayCommand(IncreaseCounterAndUpdateMessage);
        _navService = navService;
        _count = 0;
    }

    private void IncreaseCounterAndUpdateMessage()
    {
        _count++;
        Message = $"This button bellow has been pressed {_count} times";
    }

    private async Task GoToFirstPageAsync()
    {
        await _navService.NavigateToFirstPageAsync();
    }
}
