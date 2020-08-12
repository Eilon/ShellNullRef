using System.ComponentModel;
using Xamarin.Forms;
using ShellNullRef.ViewModels;

namespace ShellNullRef.Views
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