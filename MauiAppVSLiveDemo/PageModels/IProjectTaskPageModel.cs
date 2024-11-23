using CommunityToolkit.Mvvm.Input;
using MauiAppVSLiveDemo.Models;

namespace MauiAppVSLiveDemo.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}