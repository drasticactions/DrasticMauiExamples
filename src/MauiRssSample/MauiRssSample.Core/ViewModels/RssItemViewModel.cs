using System.Collections.ObjectModel;
using Drastic.ViewModels;
using MauiRssSample.Core.Models;

namespace MauiRssSample.Core.ViewModels;

public class RssItemViewModel : BaseViewModel
{
    public RssItemViewModel(IEnumerable<FeedListItem> items, IServiceProvider services)
        : base(services)
    {
        this.Items = new ObservableCollection<FeedListItem>(items);
    }
    
    public ObservableCollection<FeedListItem> Items { get; }
}