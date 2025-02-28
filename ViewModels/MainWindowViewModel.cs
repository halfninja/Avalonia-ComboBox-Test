using System.Collections.ObjectModel;
using ComboBoxTest.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ComboBoxTest.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private ObservableCollection<MyListItem> _items = [
        new() { Title = "Red", Count = 1 },
        new() { Title = "Green", Count = 1 },
        new() { Title = "Blue", Count = 1 },
    ];

    [RelayCommand]
    private void AddItem()
    {
        Items.Add(new MyListItem { Title = "New Item", Count = 1 });
    }
}