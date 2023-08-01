using CommunityToolkit.Mvvm.ComponentModel;

namespace DemoApp.ViewModel;

public class SecondPageVM : ObservableObject
{
    private Command _changeLabel;
    public Command ChangeLabel { get;  }

    private void ChangeLabelCommand(object obj) {
        var label = obj as Label;
        if (TextInput == "")
        {
            label.Text = "";
            return;
        }
        label.Text="You entered :"+ TextInput;
    }
    public SecondPageVM() {
        ChangeLabel = new (ChangeLabelCommand);
        
    }
    private string _textInput;

    public string TextInput
    {
        get => _textInput;
        set => SetProperty(ref _textInput, value);
    }
}