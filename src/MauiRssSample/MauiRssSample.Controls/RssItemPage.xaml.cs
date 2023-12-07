using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiRssSample.Core;

namespace MauiRssSample.Controls;

public partial class RssItemPage : ContentPage
{
    public RssItemPage(IServiceProvider provider)
    {
        InitializeComponent();
        var template = new RssPage()
        {
            IsDarkMode = true
        };

        var result = template.Render();
        var htmlSource = new HtmlWebViewSource();
        htmlSource.Html = result;
        this.RssWebView.Source = htmlSource;
    }
}