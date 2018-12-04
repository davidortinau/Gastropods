using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Gastropod
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            (App.Current.MainPage as Shell).GoToAsync(new ShellNavigationState("app://xamarin.com/gastropod/tabsandwich/activity/notifications"), true);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as Shell).DisplayAlert("Alert", "welcome to the jungle", "Bye");
        }
    }
}
