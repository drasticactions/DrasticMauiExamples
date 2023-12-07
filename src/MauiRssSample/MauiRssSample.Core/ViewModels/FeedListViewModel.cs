using System.Collections.ObjectModel;
using Drastic.ViewModels;
using MauiRssSample.Core.Models;

namespace MauiRssSample.Core.ViewModels;

public class FeedListViewModel : BaseViewModel
{
    public FeedListViewModel(FeedListItem item, IServiceProvider services)
        : base(services)
    {
        this.SelectedItem = item;
    }
    
    public FeedListViewModel(FeedListItem item, IEnumerable<FeedItem> items, IServiceProvider services)
        : base(services)
    {
        this.SelectedItem = item;
        this.Items = new ObservableCollection<FeedItem>(items);
    }
    
    public ObservableCollection<FeedItem> Items { get; internal set; } = new ();
    
    public FeedListItem SelectedItem { get; internal set; }

    public async Task ReloadItemsAsync(FeedListItem item)
    {
        this.SelectedItem = item;
        this.Items.Clear();
    }
    
    public async Task ReloadItemsAsync(FeedListItem item, IEnumerable<FeedItem> items)
    {
        this.SelectedItem = item;
        this.Items = new ObservableCollection<FeedItem>(items);
    }
}