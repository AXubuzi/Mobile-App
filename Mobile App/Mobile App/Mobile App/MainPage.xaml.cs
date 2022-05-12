using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void HomePage_Chicked(object sender, EventArgs e)
        {

        }

        

    }
    
  
}
