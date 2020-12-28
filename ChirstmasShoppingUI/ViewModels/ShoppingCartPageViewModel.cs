using System;
using System.Collections.ObjectModel;
using ChirstmasShoppingUI.Models;

namespace ChirstmasShoppingUI.ViewModels
{
    public class ShoppingCartPageViewModel
    {
        public ObservableCollection<Items> items { get; set; }
        public ShoppingCartPageViewModel()
        {
            items = new ObservableCollection<Items>
            {
                new Items
                {
                    Picture="Details1",
                    Title = "Corgi Bear Sewing Supplies",
                    By ="By Fluffmonger",
                    Quantity = "x1",
                    Price = "$50.99"
                },
                new Items
                {
                    Picture="Details2",
                    Title = "Reindeer Crochet Hat",
                    By ="By EmmasToys",
                    Quantity = "x1",
                    Price = "$30.87"
                },
                new Items
                {
                    Picture="Details3",
                    Title = "Reindeer Socks Power Blue",
                    By ="By TheWarmCats",
                    Quantity = "x1",
                    Price = "$8.56"
                }
            };
        }
    }
}
