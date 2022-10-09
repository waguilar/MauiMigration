using MauiMigration.ViewModels;
using System.ComponentModel;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace MauiMigration.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}