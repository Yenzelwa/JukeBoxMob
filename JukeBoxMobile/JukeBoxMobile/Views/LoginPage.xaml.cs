﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JukeBoxMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

       

        async void Login_Clicked(object sender, EventArgs e)
        {
            //App.userIsLogin = true;
            App.Current.MainPage = new RootPage();
        }
    }
}