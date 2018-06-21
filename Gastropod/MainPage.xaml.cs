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
            (App.Current.MainPage as Shell).GoToAsync(new ShellNavigationState("http://www.xamarin.com/gastropod/tabsandwich/activity/notifications"), true);
        }
    }
}
