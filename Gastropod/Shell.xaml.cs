
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Gastropod
{
    public partial class Shell : Xamarin.Forms.Shell
    {
        public ICommand TakePhotoCommand => new Command(GoToCamera);
        public Shell()
        {
            InitializeComponent();

            Routing.RegisterRoute("notifications", typeof(NotificationsPage));
            Routing.RegisterRoute("photo", typeof(CameraPage));

            BindingContext = this;
        }

        void GoToCamera()
        {
            (App.Current.MainPage as Xamarin.Forms.Shell).GoToAsync("app:///gastropod/toptabs/activity/photo?payload=4.0", true);
            (App.Current.MainPage as Xamarin.Forms.Shell).FlyoutIsPresented = false;
        }
    }
}
