using FortniteApp.DTO;
using FortniteApp.Fetch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Connectivity;
using FortniteApp.Error;

namespace FortniteApp.Pages
{
    public partial class MainPage : ContentPage
    {        
        private Button Weapon;
        private Button Chest;
        private Label Errortext;

        public MainPage()
        {
            var layout = new StackLayout();

            layout.Children.Add(Weapon = new Button
            {
                Text = "Weapons"
            });

            layout.Children.Add(Chest = new Button
            {
                Text = "Chest"
            });

            layout.Children.Add(Errortext = new Label
            {
                IsVisible = false,
                TextColor = Color.Red
            });

            Weapon.Clicked += FetchingWeapons;
            Chest.Clicked += FetchingChests;

            Content = layout;
        }

        public async void FetchingWeapons(object sender, EventArgs e)
        {
            //fetch = new Fetcher();

            Errortext.IsVisible = false;
            //var result = await fetch.FetchWeapon();
            WeaponPage page = new WeaponPage();
            await Navigation.PushAsync(page);

            //Errortext.Text = ErrorText.BadConnection();
            //Errortext.IsVisible = true;

        }

        public void FetchingChests(object sender, EventArgs e)
        {
            //fetch = new Fetcher();

            Errortext.IsVisible = false;
            //var result = await fetch.FetchChests();

            Errortext.Text = ErrorText.BadConnection();
            Errortext.IsVisible = true;

        }
    }
}
