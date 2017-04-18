using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.FormsBook.Toolkit;

using Xamarin.Forms;

namespace MVVMCalculator
{
    public partial class App : Application
    {
        AdderViewModel adderViewModel;
        public App()
        {
            adderViewModel = new AdderViewModel();
            adderViewModel.RestoreState(Current.Properties);
            MainPage = new MainPage(adderViewModel);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            adderViewModel.SaveState(Current.Properties);
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
