namespace SampleMauiApp;

using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

public partial class App : Application
{
	public App()
	{
		this.LoadFromXaml(typeof(App));

		MainPage = new AppShell();
	}
}
