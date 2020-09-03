using System;
using System.Collections.Generic;
using PruebaShellTabbar.ViewModels;
using PruebaShellTabbar.Views;
using Xamarin.Forms;

namespace PruebaShellTabbar
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
