﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JukeBoxMobile.Views.MusicLibrary
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SongPage : ContentPage
	{
		public SongPage ()
		{
			InitializeComponent ();
		}
	}
}