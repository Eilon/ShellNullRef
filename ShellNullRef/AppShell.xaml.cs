using System;
using System.Collections.Generic;
using ShellNullRef.ViewModels;
using ShellNullRef.Views;
using Xamarin.Forms;

namespace ShellNullRef
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            this.BindingContext = new ShellViewModel();
        }
    }
}
