using System.ComponentModel;
using Xamarin.Forms;
using TestApp1.ViewModels;

namespace TestApp1.Views
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
