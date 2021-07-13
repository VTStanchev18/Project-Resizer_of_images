using Resizer_of_images_v2.ViewModels;
using Resizer_of_images_v2.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Resizer_of_images_v2
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
