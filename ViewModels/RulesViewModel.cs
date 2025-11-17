using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AlchemyByKirill_v_sqllite.ViewModels
{
    public partial class RulesViewModel : ObservableObject
    {
        public RulesViewModel()
        {
        }

        [RelayCommand]
        async Task GoBack()
        {

            await Shell.Current.GoToAsync("..");
        }
    }
}