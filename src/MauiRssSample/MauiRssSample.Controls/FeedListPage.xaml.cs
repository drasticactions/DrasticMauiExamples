using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drastic.Tools;
using MauiRssSample.Core.Models;
using MauiRssSample.Core.ViewModels;

namespace MauiRssSample.Controls;

public partial class FeedListPage : ContentPage
{
    private FeedListViewModel vm;
    
    public FeedListPage(IServiceProvider provider)
    {
        InitializeComponent();
        var items = new List<FeedItem>();
        for (var i = 0; i < 100; ++i)
        {
            items.Add(new FeedItem()
            {
                Title = "Test",
                Author = "Author Test",
                Description = "Test",
                Link = "https://google.com",
                PublishingDate = DateTime.Now,
            });
        }
        this.BindingContext = this.vm = provider.ResolveWith<FeedListViewModel>(
            new FeedListItem()
            {
                Name = "Daring Fireball",
                Uri = new Uri("https://daringfireball.net/feeds/main"),
            },
            items
        );
    }
}