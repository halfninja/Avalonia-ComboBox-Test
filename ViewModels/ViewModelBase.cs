using System.Collections.ObjectModel;
using ComboBoxTest.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ComboBoxTest.ViewModels;

public partial class ViewModelBase : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<MyListItem> _items = [
        new() { Title = "Red", Count = 1 },
        new() { Title = "Green", Count = 1 },
        new() { Title = "Blue", Count = 1 },
    ];
}