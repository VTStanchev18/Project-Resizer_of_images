using Resizer_of_images_v2.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Resizer_of_images_v2.Views
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