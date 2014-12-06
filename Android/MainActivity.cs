using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using Parse;


namespace LocateMe.Android
{
	[Activity (Label = "LocateMe.Android.Android", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : AndroidActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			Xamarin.Forms.Forms.Init (this, bundle);

			SetPage (App.GetMainPage ());

			ParseClient.Initialize ("hXXW5OH2FtyLKaStLnTscsyUhAMmLbByOrt4Srxb", "rvAZ1WRC1FdjXJBzYkpLOrzWthLeXG8sEpGF7lu4");
		}
	}
}

