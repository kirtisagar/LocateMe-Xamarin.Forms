using System;
using Parse;
//using ParseService;
using Xamarin.Forms;
using LocateMe.Android;

[assembly: Xamarin.Forms.Dependency (typeof (ParseService))]
namespace LocateMe.Android
{
	public class ParseService :IParse
	{
		#region IParse implementation

		public string GetUsers (string objectId)
		{

			var par = new par ();




			return null;
		}

		#endregion


	}
}

