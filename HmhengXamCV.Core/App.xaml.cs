using HmhengXamCV.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HmhengXamCV
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            AppConstants.ComputerVisionApiKey = "c2f3d25ca5c64293ac8a1144859e2339";
            AppConstants.BingWebSearchApiKey = "e98c0ebd3c824bdf858cde54273ece19";

              //Applicable OCR server locations (at time of writing) are: westus, eastus2, westcentralus, westeurope, southeastasia 
            AppConstants.SetOcrLocation("westcentralus");

              MainPage = new NavigationPage(new OcrSelectPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
