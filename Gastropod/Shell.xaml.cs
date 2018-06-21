using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Gastropod
{
    public partial class Shell : Xamarin.Forms.Shell
    {
        public Shell()
        {
            InitializeComponent();

            Routing.RegisterRoute("notifications", typeof(NotificationsPage));
        }
    }
}
