using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChirstmasShoppingUI.Views
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();
        }

        async void Btn_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.ShoppingCartPage());
        }
    }
}
