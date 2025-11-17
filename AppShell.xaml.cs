using AlchemyByKirill_v_sqllite.Views;

namespace AlchemyByKirill_v_sqllite;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(GamePage), typeof(GamePage));
        Routing.RegisterRoute(nameof(LibraryPage), typeof(LibraryPage));
        Routing.RegisterRoute(nameof(RulesPage), typeof(RulesPage));
    }
}