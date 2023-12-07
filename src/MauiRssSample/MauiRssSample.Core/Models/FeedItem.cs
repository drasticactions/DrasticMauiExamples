namespace MauiRssSample.Core.Models;

public class FeedItem
{
    /// <summary>
    /// Gets or sets the title of the feed item.
    /// </summary>
    public string? Title
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets link (url) to the feed item.
    /// </summary>
    public string? Link
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets link (url) to the feed item.
    /// </summary>
    public string? ExternalLink
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets description of the feed item.
    /// </summary>
    public string? Description
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets The publishing date as string.
    /// </summary>
    public string? PublishingDateString
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets The published date as datetime.
    /// </summary>
    public DateTime? PublishingDate
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets The author of the feed item.
    /// </summary>
    public string? Author
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets The content of the feed item.
    /// </summary>
    public string? Content
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets The html of the feed item.
    /// </summary>
    public string? Html
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets The image url of the feed item.
    /// </summary>
    public string? ImageUrl
    {
        get;
        set;
    }
}