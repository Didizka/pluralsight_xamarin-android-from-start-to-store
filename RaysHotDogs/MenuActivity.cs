﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System;

namespace RaysHotDogs
{
    [Activity(Label = "Ray's Hot Dogs", MainLauncher = true, Icon = "@drawable/smallicon")]
    public class MenuActivity : Activity
    {
        private Button orderButton;
        private Button cartButton;
        private Button aboutButton;
        private Button mapButton;
        private Button takePictureButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainMenu);

            FindViews();
            HandleEvents();

            
        }

        private void FindViews()
        {
            orderButton = FindViewById<Button>(Resource.Id.orderButton);
            cartButton = FindViewById<Button>(Resource.Id.cartButton);
            aboutButton = FindViewById<Button>(Resource.Id.aboutButton);
            mapButton = FindViewById<Button>(Resource.Id.mapButton);
            takePictureButton = FindViewById<Button>(Resource.Id.takePictureButton);
        }

        private void HandleEvents()
        {
            orderButton.Click += OrderButton_Click;
            //cartButton.Click += CartButton_Click;
            aboutButton.Click += AboutButton_Click;
            mapButton.Click += MapButton_Click;
            takePictureButton.Click += TakePictureButton_Click;
        }

        private void TakePictureButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(TakePictureActivity));
            StartActivity(intent);
        }

        private void MapButton_Click(object sender, EventArgs e)
        {
            try
            {
                var intent = new Intent(this, typeof(RayMapActivity));
                StartActivity(intent);
            }
            catch (Exception ex)
            {
                var a = ex.Message;
                var dialog = new AlertDialog.Builder(this);
                dialog.SetTitle("Confirmation");
                dialog.SetMessage(string.Format("Error: {0}",a));
                dialog.Show();
                throw;
            }

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(AboutActivity));
            StartActivity(intent);
        }

        //private void CartButton_Click(object sender, EventArgs e)
        //{
        //    var intent = new Intent(this, typeof(CartActivity));
        //    StartActivity(intent);
        //}

        private void OrderButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(HotDogMenuActivity));
            StartActivity(intent);
        }
    }
}