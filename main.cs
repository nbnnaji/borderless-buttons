/*Homescreen*/

using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;

namespace My_App
{
    [Activity(Label = "Home", MainLauncher = true, Icon = "@drawable/logo")]

    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);// Main is the homescreen


            Button buttonOne = FindViewById<Button>(Resource.Id.ButtonOne);
                buttonOne.Click += delegate
            {
                var intent = new Intent(this, typeof(Activity2));// opens the screen for Activity2 screen page
                StartActivity(intent);

            };

            Button VideoButton = FindViewById<Button>(Resource.Id.VideoButton);// This method looks up the video button controller.
            VideoButton.Click += delegate// Click event using a delegate which listens for the user's touch/click of the video  button.
            {
                var uri = Android.Net.Uri.Parse("https://www.youtube.com ");// Weblink is opened using mobile device web browser.
                var openVideoLink = new Intent(Intent.ActionView, uri);
                StartActivity(openVideoLink);//Starts the click event.
            };

            Button button2 = FindViewById<Button>(Resource.Id.Button2);// This methods looks up the button2 controller.
            Button2.Click += delegate
        {
            var uri = Android.Net.Uri.Parse("http://www.yahoo.com");
            var openmyyahoolink = new Intent(Intent.ActionView, uri);
            StartActivity(openmyyahoolink);
        };

		//Textview is made clickable
            TextView textview1 = FindViewById<TextView>(Resource.Id.textviewOne)
            Textview1.Click += delegate
            {
                var intent = new Intent(this, typeof(Activity3));// opens the screen for Activity3
                StartActivity(intent);

            };
            Button FAQsButton= FindViewById <Button> (Resource.Id.FAQsButton);
            FAQsButton.Click += delegate
            {
                 var intent = new Intent(this, typeof(FAQsActivity));
                 StartActivity(intent);

             };

            Button AboutButton = FindViewById<Button>(Resource.Id.AboutButton);

            AboutButton.Click += delegate
             {
                 var intent = new Intent(this, typeof(AboutActivity));
                 StartActivity(intent);

             };
            }    
   }

       
    }




