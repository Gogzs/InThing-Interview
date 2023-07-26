using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.ViewModel;

public class FirstPageVM : ObservableRecipient
{
	private string _textInput;

	public string TextInput
	{
		get => _textInput; 
		set => SetProperty(ref _textInput, value); 
	}
}
