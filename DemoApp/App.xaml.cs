﻿namespace DemoApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = ActivatorUtilities.CreateInstance<AppShell>(MauiProgram.Services);
	}
}
