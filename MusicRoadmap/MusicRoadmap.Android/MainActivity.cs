using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;
using MusicRoadmap.Repositories;

namespace MusicRoadmap.Droid
{
	[Activity (Label = "MusicRoadmap.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);


        }
    }
}


