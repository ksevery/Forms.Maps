using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Maps.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MapsPage : ContentPage
	{
		public MapsPage ()
		{
			InitializeComponent ();
            this.MainMap.UiSettings.MyLocationButtonEnabled = true;
        }
	}
}