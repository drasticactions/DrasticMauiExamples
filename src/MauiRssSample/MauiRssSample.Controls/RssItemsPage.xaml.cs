using System;
using System.Collections.Generic;
using Drastic.Tools;
using MauiRssSample.Core.Models;
using MauiRssSample.Core.ViewModels;
using Microsoft.Maui.Controls;

namespace MauiRssSample.Controls;

public partial class RssItemsPage : ContentPage
{
    private RssItemViewModel vm;
    
    public RssItemsPage(IServiceProvider provider)
    {
        InitializeComponent();
        this.BindingContext = this.vm = provider.ResolveWith<RssItemViewModel>(
            new List<FeedListItem>()
            {
                new FeedListItem()
                {
                    Name = "Daring Fireball",
                    Uri = new Uri("https://daringfireball.net/feeds/main"),
                }
            }
        );
    }
}