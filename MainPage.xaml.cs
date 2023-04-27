using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;

namespace SampleMauiApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		this.LoadFromXaml(typeof(MainPage));
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		/*
		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
		*/
	}
}

