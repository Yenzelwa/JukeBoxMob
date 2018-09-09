using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JukeBoxMobile.ViewModels;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JukeBoxMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MusicDetailPage : ContentPage
	{
		public MusicDetailPage ()
		{
			InitializeComponent ();
         //   BindingContext = new MusicDetailViewModel();
        }

        private void Payment_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PaymentPagePopUp());

        }
    }
}