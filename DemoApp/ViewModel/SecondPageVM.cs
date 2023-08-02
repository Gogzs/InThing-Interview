using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using PropertyChanged;

namespace DemoApp.ViewModel;

public class SecondPageVM : ObservableObject, INotifyPropertyChanged
{
    [AddINotifyPropertyChangedInterface]

    //labela za unos
    private string _textInput;

    public string TextInput
    {
        get => _textInput;
        set => SetProperty(ref _textInput, value);
    }

    //labela za ispis
    private string _textOutput;
    public string TextOutput { get; set; }


    //komanda za klik botunom
    public Command ResultCommand => new Command(CommandResult);

    private void CommandResult(object obj)
    {
        TextOutput = TextInput;
    }

    public SecondPageVM() {
       
       
       
        
    }
    
}

internal class AddINotifyPropertyChangedInterfaceAttribute : Attribute
{
}