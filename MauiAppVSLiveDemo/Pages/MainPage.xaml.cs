using MauiAppVSLiveDemo.Models;
using MauiAppVSLiveDemo.PageModels;

namespace MauiAppVSLiveDemo.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}