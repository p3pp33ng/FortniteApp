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
	public partial class PistolPage : ContentPage
	{
		public PistolPage (List<PistolDTO> list)
		{
            var layout = new StackLayout();
		}
	}
}