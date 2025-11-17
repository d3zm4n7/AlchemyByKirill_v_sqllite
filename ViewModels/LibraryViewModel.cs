using System.Collections.ObjectModel;
using AlchemyByKirill_v_sqllite.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Element = AlchemyByKirill_v_sqllite.Models.Element;

namespace AlchemyByKirill_v_sqllite.ViewModels;

public partial class LibraryViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Element> elements = new();

    public void Load(ObservableCollection<Element> discovered)
    {
        Elements = discovered;
    }

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}