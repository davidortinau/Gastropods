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

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            //await (App.Current.MainPage as Shell).GoToAsync(new ShellNavigationState("app://www.xamarin.com/gastropods/tabsandwich/activity/notifications?welcome=Doooood"), true);
            var shell = Application.Current.MainPage as Shell;
            await shell.GoToAsync("app:///gastropods/tabsandwich/activity/notifications?welcome=Doooood");

        }
    }
}