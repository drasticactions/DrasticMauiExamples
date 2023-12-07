using Drastic.Tools;
using MauiRssSample.Core.Models;
using MauiRssSample.Core.ViewModels;

namespace MauiRssSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(IServiceProvider provider)
	{
		InitializeComponent();
	}
}

