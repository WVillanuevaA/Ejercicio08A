using System.ComponentModel;
using Ejercicio08.ViewModels;
using Xamarin.Forms;

namespace Ejercicio08.Views
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