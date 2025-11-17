using AlchemyByKirill_v_sqllite.ViewModels;

namespace AlchemyByKirill_v_sqllite.Views;

public partial class RulesPage : ContentPage
{
    public RulesPage(RulesViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}