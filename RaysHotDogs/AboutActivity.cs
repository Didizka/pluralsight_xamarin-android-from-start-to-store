using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System;

namespace RaysHotDogs
{
    [Activity(Label = "About Ray's Hot Dogs", Icon = "@drawable/smallicon")]
    public class AboutActivity : Activity
    {
        private TextView phoneNumberTextView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AboutView);

            FindViews();
            HandleEvents();
        }

        private void HandleEvents()
        {
            phoneNumberTextView.Click += PhoneNumberTextView_Click;
        }

        private void PhoneNumberTextView_Click(object sender, EventArgs e)
        {
            var intent = new Intent(Intent.ActionCall);
            intent.SetData(Android.Net.Uri.Parse("tel:" + phoneNumberTextView.Text));
            StartActivity(intent);
        }

        private void FindViews()
        {
            phoneNumberTextView = FindViewById<TextView>(Resource.Id.phoneNumberTextView);
        }
    }
}