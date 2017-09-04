using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xappia
{
    public partial class App : Application
    {
        public static String RutaDB;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Xappia.MainPage());
        }

        public App(String rutaDb)
        {
            InitializeComponent();

            RutaDB = rutaDb;

            MainPage = new NavigationPage(new Xappia.MainPage());

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
