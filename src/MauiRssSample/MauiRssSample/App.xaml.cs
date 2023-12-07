using MauiRssSample.Controls;

namespace MauiRssSample;

public partial class App : Application
{
	public App(IServiceProvider provider)
	{
		InitializeComponent();

		MainPage = new FeedListPage(provider);
	}
}
