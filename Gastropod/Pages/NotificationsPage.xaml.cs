using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gastropod
{
    [QueryProperty("Greeting", "welcome")]
    public partial class NotificationsPage : ContentPage, INotifyPropertyChanged
    {
        public NotificationsPage()
        {
            BindingContext = this;

            InitializeComponent();
        }

        private string _greeting = "Nothing";
        public string Greeting
        {
            get
            {
                return _greeting;
            }
            set
            {
                _greeting = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
