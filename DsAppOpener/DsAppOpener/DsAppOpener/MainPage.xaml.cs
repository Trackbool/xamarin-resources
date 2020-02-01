using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DsAppOpener
{
    public partial class MainPage : ContentPage
    {
        IAppOpener appOpener;
        public MainPage()
        {
            InitializeComponent();

            appOpener = DependencyService.Get<IAppOpener>();
        }

        private void OpenFacebookApp_Clicked(object sender, EventArgs e)
        {
            appOpener.OpenFacebook();
        }

        private void OpenInstagramApp_Clicked(object sender, EventArgs e)
        {
            appOpener.OpenInstagram();
        }

        private void OpenYoutubeApp_Clicked(object sender, EventArgs e)
        {
            appOpener.OpenYoutube();
        }
    }
}
