using Drastic.Services;

namespace MauiRssSample.Services;

public class MauiAppDispatcher : IAppDispatcher
{
    public bool Dispatch(Action action)
    {
        return Microsoft.Maui.Controls.Application.Current?.Dispatcher.Dispatch(action) ?? false;
    }
}