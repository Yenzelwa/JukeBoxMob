﻿using System;
using JukeBoxMobile.Models;
using JukeBoxMobile.ViewModels;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace JukeBoxMobile.Views
{
    public partial class FeaturedPage : ContentPage
    {

        public FeaturedPage()
        {
            InitializeComponent();
            BindingContext = new LibraryViewModel();

         
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MusicDetailPage());
        }
        public double clicks = 0;

 

        private void BtnIncrement_OnClicked(object sender, EventArgs e)
        {
            clicks += 1;
            CustomNavigationBar bar = new CustomNavigationBar();
            bar.FirstNameLabel.Text = clicks.ToString();


           // NavigationBarView.FirstNameLabel.Text = clicks.ToString();
        }


        async void OnTapped_ViewMusic(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new MusicDetailPage());
        }




    }
}



