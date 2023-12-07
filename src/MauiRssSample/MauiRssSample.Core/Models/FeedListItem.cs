using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiRssSample.Core.Models;

public class FeedListItem : INotifyPropertyChanged
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FeedListItem"/> class.
    /// </summary>
    public FeedListItem()
    {
    }
    
    /// <summary>
    /// Gets or sets the feed name.
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    /// Gets or sets link (url) to the feed item.
    /// </summary>
    public string? Link
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets the feed description.
    /// </summary>
    public string? Description { get; set; }
    
    /// <summary>
    /// Gets or sets the Feed Uri.
    /// </summary>
    public Uri? Uri { get; set; }
    
    /// <summary>
    /// Gets or sets the last updated date.
    /// </summary>
    public DateTime? LastUpdatedDate { get; set; }

    /// <summary>
    /// Gets or sets the last updated date string.
    /// </summary>
    public string? LastUpdatedDateString { get; set; }

    /// <inheritdoc/>
    public event PropertyChangedEventHandler? PropertyChanged;
    
#pragma warning disable SA1600 // Elements should be documented
    protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "", Action? onChanged = null)
#pragma warning restore SA1600 // Elements should be documented
    {
        if (EqualityComparer<T>.Default.Equals(backingStore, value))
        {
            return false;
        }

        backingStore = value;
        onChanged?.Invoke();
        this.OnPropertyChanged(propertyName);
        return true;
    }

    /// <summary>
    /// On Property Changed.
    /// </summary>
    /// <param name="propertyName">Name of the property.</param>
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        var changed = this.PropertyChanged;
        if (changed == null)
        {
            return;
        }

        changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}