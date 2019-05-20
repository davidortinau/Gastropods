using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Gastropod.Pages
{
    public partial class LoginPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Shell.Current.Navigation.PopModalAsync();
        }

        public LoginPage()
        {
            InitializeComponent();
        }
    }
}
