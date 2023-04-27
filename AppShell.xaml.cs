using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace SampleMauiApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		this.LoadFromXaml(typeof(AppShell));
	}
}
