using FortniteApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FortniteApp.Fetch;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FortniteApp.Error;

namespace FortniteApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeaponPage : ContentPage
    {
        //private ListView listView;
        private WeaponsList weaponList;
        private Button pistols;
        private Button assualtRifle;
        private Button submachinegun;
        private Button sniper;
        private Button explosives;
        private Button shotgun;
        private Label errorText;

        public WeaponPage()
        {
            var layout = new StackLayout();
            FetchWeapons();
            layout.Children.Add(pistols = new Button
            {
                Text = "Pistols",
                BackgroundColor = Color.ForestGreen,
                TextColor = Color.Black
            });
            layout.Children.Add(assualtRifle = new Button
            {
                Text = "Rifles",
                BackgroundColor = Color.ForestGreen,
                TextColor = Color.Black
            });
            layout.Children.Add(submachinegun = new Button
            {
                Text = "Submachine guns",
                BackgroundColor = Color.ForestGreen,
                TextColor = Color.Black
            });
            layout.Children.Add(shotgun = new Button
            {
                Text = "Shotguns",
                BackgroundColor = Color.ForestGreen,
                TextColor = Color.Black
            });
            layout.Children.Add(explosives = new Button
            {
                Text = "Explosives",
                BackgroundColor = Color.ForestGreen,
                TextColor = Color.Black
            });
            layout.Children.Add(sniper = new Button
            {
                Text = "Sniper rifles",
                BackgroundColor = Color.ForestGreen,
                TextColor = Color.Black
            });
            layout.Children.Add(errorText = new Label
            {
                IsVisible = false,
                TextColor = Color.Red
            });

            pistols.Clicked += Pistols_Clicked;
            assualtRifle.Clicked += AssualtRifle_Clicked;
            submachinegun.Clicked += Submachinegun_Clicked;
            shotgun.Clicked += Shotgun_Clicked;
            explosives.Clicked += Explosives_Clicked;
            sniper.Clicked += Sniper_Clicked;


            Content = layout;
        }

        private void Sniper_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Explosives_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Shotgun_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Submachinegun_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AssualtRifle_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void Pistols_Clicked(object sender, EventArgs e)
        {
            if (weaponList.Pistols.Any())
            {
                errorText.IsVisible = false;
                PistolPage page = new PistolPage(weaponList.Pistols);
                await Navigation.PushAsync(page);
            }
            else
            {
                errorText.Text = ErrorText.WereNotFound();
                errorText.IsVisible = true;
            }            
        }

        private async void FetchWeapons()
        {
            var fetcher = new Fetcher();
            weaponList = await fetcher.FetchWeapon();
        }
    }
}