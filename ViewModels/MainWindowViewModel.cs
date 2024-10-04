using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace wasteland_launcher.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private ViewModelBase _currentPage = new HomePageViewModel();
    [ObservableProperty]
    private int _selectedIndex = 0;
    
    partial void OnSelectedIndexChanged(int value)
    {
        switch (value)
        {
            case 0:
                CurrentPage = new HomePageViewModel();
                break;
            case 2:
                CurrentPage = new OpenSourceViewModel();
                break;
            case 3:
                CurrentPage = new SupportPageViewModel();
                break;
            default:
                CurrentPage = new HomePageViewModel();
                break;
        }
    }
}  