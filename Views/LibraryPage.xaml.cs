using AlchemyByKirill_v_sqllite.ViewModels;
using Microsoft.Maui.Controls;
using System;
using AlchemyByKirill_v_sqllite.Views;


namespace AlchemyByKirill_v_sqllite.Views;

public partial class LibraryPage : ContentPage
{
    public LibraryPage(LibraryViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
