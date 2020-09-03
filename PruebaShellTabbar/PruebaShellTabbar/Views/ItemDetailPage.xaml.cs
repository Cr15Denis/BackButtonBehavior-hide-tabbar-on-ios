using System.ComponentModel;
using Xamarin.Forms;
using PruebaShellTabbar.ViewModels;

namespace PruebaShellTabbar.Views
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