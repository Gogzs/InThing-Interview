using CommunityToolkit.Mvvm.ComponentModel;

namespace DemoApp.ViewModel;

public class SecondPageVM : ObservableRecipient
{
    private string _textInput;

    public string TextInput
    {
        get => _textInput;
        set => SetProperty(ref _textInput, value);
    }
}