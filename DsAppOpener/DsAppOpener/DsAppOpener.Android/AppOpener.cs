using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Uri = Android.Net.Uri;

[assembly: Dependency(typeof(DsAppOpener.Droid.AppOpener))]
namespace DsAppOpener.Droid
{
    class AppOpener : IAppOpener
    {
        public void OpenFacebook()
        {
            const string APP_ID = "com.facebook.katana";
            const string WEB_URL = "https://www.facebook.com/Pokemon";
            const string APP_URI = "fb://facewebmodal/f?href=" + WEB_URL;

            OpenAppOrBrowser(APP_ID, APP_URI, WEB_URL);
        }

        public void OpenInstagram()
        {
            const string APP_ID = "com.instagram.android";
            const string WEB_URL = "https://instagram.com/adrianfa5";
            const string APP_URI = "http://instagram.com/_u/adrianfa5";

            OpenAppOrBrowser(APP_ID, APP_URI, WEB_URL);
        }

        public void OpenYoutube()
        {
            const string APP_ID = "com.google.android.youtube";
            const string WEB_URL = "https://www.youtube.com/channel/UC44CQv-m-yQ_seLssemPlmQ";
            const string APP_URI = "https://www.youtube.com/channel/UC44CQv-m-yQ_seLssemPlmQ";

            OpenAppOrBrowser(APP_ID, APP_URI, WEB_URL);
        }

        private static void OpenAppOrBrowser(string appId, string appUri, string browserUrl)
        {
            var context = Android.App.Application.Context;
            Uri uri = Uri.Parse(browserUrl);
            try
            {
                ApplicationInfo appInfo = context.PackageManager.GetApplicationInfo(appId, 0);
                if (appInfo.Enabled)
                {
                    uri = Uri.Parse(appUri);
                }
            }
            catch (Exception) { }

            Intent intent = new Intent(Intent.ActionView, uri);
            intent.SetFlags(ActivityFlags.NewTask);
            context.StartActivity(intent);
        }
    }
}