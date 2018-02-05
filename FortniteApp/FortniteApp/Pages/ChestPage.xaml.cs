using FortniteApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FortniteApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChestPage : ContentPage
	{
        private ListView listView;
		public ChestPage (ChestDTO data)
		{			
            var layout = new StackLayout();

            layout.Children.Add(listView = new ListView
            {

            });
		}
	}
}