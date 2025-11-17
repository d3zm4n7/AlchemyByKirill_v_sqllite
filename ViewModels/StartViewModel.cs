using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input; // Добавь это
using AlchemyByKirill_v_sqllite.Views; // Убедись, что это добавлено

namespace AlchemyByKirill_v_sqllite.ViewModels
{
    public partial class StartViewModel : ObservableObject
    {
        public StartViewModel()
        {
        }

        [RelayCommand]
        async Task GoToGame()
        {
            await Shell.Current.GoToAsync(nameof(GamePage));
        }

        [RelayCommand]
        async Task GoToLibrary()
        {

            await Shell.Current.GoToAsync(nameof(LibraryPage));
        }

        [RelayCommand]
        async Task GoToRules()
        {
            await Shell.Current.GoToAsync(nameof(RulesPage));
        }
        [RelayCommand]
        void ExitApp()
        {
            Application.Current.Quit();
        }
    }
}