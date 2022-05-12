using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationPage navigationPage = new NavigationPage(new MainPage());
            navigationPage.BarBackgroundColor = Color.Black;
            MainPage = navigationPage;
        }

       
    }
}
