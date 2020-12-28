using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChirstmasShoppingUI.Views
{
    public partial class ShoppingCartPage : ContentPage
    {
        public ShoppingCartPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ShoppingCartPageViewModel();
        }
    }
}
